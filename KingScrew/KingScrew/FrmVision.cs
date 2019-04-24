using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cognex.VisionPro.ImageFile;
using Cognex.VisionPro;

namespace KingScrew
{
	public partial class FrmVision : Form
	{
		public FrmVision()
		{
			InitializeComponent();
		}

		private void FrmJobManager_Load(object sender, EventArgs e)
		{
			cogToolBlockEditV21.Subject = Vision.Tb1;
			cogToolBlockEditV22.Subject = Vision.Tb2;
			cogToolBlockEditV23.Subject = Vision.Tb3;
			
		}

		private void FrmVision_FormClosing(object sender, FormClosingEventArgs e)
		{
			ProductManager.RefreshConfigItems(ProductManager.GetCurProduct());
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string str = ProductManager.SaveVision();
			if (str == "OK")
			{
				MsgBox.Show("保存成功");
				Globals.MLog.Info("保存视觉程序");
			}
			else
			{
				MsgBox.Show("保存失败：" + str);
				Globals.MLog.Error("保存视觉程序出错：" + str);
			}

		}

		private void btnShot1_Click(object sender, EventArgs e)
		{
			if (Acqs.Acq1.Operator != null)
			{
				Acqs.Acq1.Operator.OwnedTriggerParams.TriggerModel = Cognex.VisionPro.CogAcqTriggerModelConstants.Manual;
				Acqs.Acq1.Run();
				Vision.WriteBlockInput(Vision.Tb1, "Image", Acqs.Acq1.OutputImage);
			}
			else
			{
				MsgBox.Show("相机未连接", ico: MessageBoxIcon.Error);
			}
		}

		private void btnOpen1_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Acqs.IFTool.Operator.Open(openFileDialog1.FileName, CogImageFileModeConstants.Read);
				Acqs.IFTool.Run();
				Vision.WriteBlockInput(Vision.Tb1, "Image", Acqs.IFTool.OutputImage);
				Vision.Tb1.Run();
			}
		}

		private void btnRun1_Click(object sender, EventArgs e)
		{
			string rs = string.Join("\r\n", Vision.RunCam1Program(Vision.Tb1.Inputs["Image"].Value as ICogImage));
			MsgBox.Show(rs);
		}

		private void btnShot2_Click(object sender, EventArgs e)
		{
			if (Acqs.Acq2.Operator != null)
			{
				Acqs.Acq2.Operator.OwnedTriggerParams.TriggerModel = Cognex.VisionPro.CogAcqTriggerModelConstants.Manual;
				Acqs.Acq2.Run();
				Vision.WriteBlockInput(Vision.Tb2, "Image", Acqs.Acq2.OutputImage);
			}
			else
			{
				MsgBox.Show("相机未连接", ico: MessageBoxIcon.Error);
			}
		}

		private void btnOpen2_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Acqs.IFTool.Operator.Open(openFileDialog1.FileName, CogImageFileModeConstants.Read);
				Acqs.IFTool.Run();
				Vision.WriteBlockInput(Vision.Tb2, "Image", Acqs.IFTool.OutputImage);
				Vision.Tb2.Run();
			}
		}

		private void btnRun2_Click(object sender, EventArgs e)
		{
			string rs = string.Join("\r\n", Vision.RunCam2Program(Vision.Tb2.Inputs["Image"].Value as ICogImage));
			MsgBox.Show(rs);	
		}

		private void btnShot3_Click(object sender, EventArgs e)
		{
			if (Acqs.Acq3.Operator != null)
			{
				Acqs.Acq3.Operator.OwnedTriggerParams.TriggerModel = Cognex.VisionPro.CogAcqTriggerModelConstants.Manual;
				Acqs.Acq3.Run();
				Vision.WriteBlockInput(Vision.Tb3, "Image", Acqs.Acq3.OutputImage);
			}
			else
			{
				MsgBox.Show("相机未连接", ico: MessageBoxIcon.Error);
			}
		}

		private void btnOpen3_Click(object sender, EventArgs e)
		{
			if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				Acqs.IFTool.Operator.Open(openFileDialog1.FileName, CogImageFileModeConstants.Read);
				Acqs.IFTool.Run();
				Vision.WriteBlockInput(Vision.Tb3, "Image", Acqs.IFTool.OutputImage);
				Vision.Tb3.Run();
			}
		}

		private void btnRun3_Click(object sender, EventArgs e)
		{
			string rs = string.Join("\r\n", Vision.RunCam3Program(Vision.Tb3.Inputs["Image"].Value as ICogImage));
			MsgBox.Show(rs);
		}
	}
}
