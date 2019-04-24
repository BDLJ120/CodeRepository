using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Cognex.VisionPro;

namespace KingScrew
{
	public partial class FrmHome : Form
	{
		public FrmHome()
		{
			InitializeComponent();
		}

		private List<int> cam1Rows = new List<int>();
		private List<int> cam2Rows = new List<int>();
		private List<int> cam3Rows = new List<int>();

		private void FrmHome_Load(object sender, EventArgs e)
		{
			btnProductName.Text = ProductManager.GetCurProduct().Name;
			Globals.runStatus = Globals.RunStatus.Ready;
			List<ConfigItem> configs = ProductManager.GetCurProduct().Configs;
			for (int i = 0; i < configs.Count; i++)
			{
				dataGridView1.Rows.Add(configs[i].CamIndex, configs[i].Key);
				switch (configs[i].CamIndex)
				{
					case 1:
						cam1Rows.Add(i);
						break;
					case 2:
						cam2Rows.Add(i);
						break;
					case 3:
						cam3Rows.Add(i);
						break;
					default:
						break;
				}
			}

			Vision.Cam1ResultAvailable += new VisionResultAvailableEventHandler(Vision_Cam1ResultAvailable);
			Vision.Cam2ResultAvailable += new VisionResultAvailableEventHandler(Vision_Cam2ResultAvailable);
			Vision.Cam3ResultAvailable += new VisionResultAvailableEventHandler(Vision_Cam3ResultAvailable);

			cogRecordDisplay1.AutoFit = true;
			cogRecordDisplay2.AutoFit = true;
			cogRecordDisplay3.AutoFit = true;
			timer1.Start();
		}

		private void FrmHome_FormClosing(object sender, FormClosingEventArgs e)
		{
			Globals.runStatus = Globals.RunStatus.Debug;

			Vision.Cam1ResultAvailable -= new VisionResultAvailableEventHandler(Vision_Cam1ResultAvailable);
			Vision.Cam2ResultAvailable -= new VisionResultAvailableEventHandler(Vision_Cam2ResultAvailable);
			Vision.Cam3ResultAvailable -= new VisionResultAvailableEventHandler(Vision_Cam3ResultAvailable);
		}

		void Vision_Cam1ResultAvailable(object sender, VisionResultAvailableEventArgs e)
		{
			string[] NGKeys = e.DataResult["NGKeys"].Split(',');
			CogGraphicLabel rsg = new CogGraphicLabel();
			rsg.SelectedSpaceName = "*";
			rsg.Alignment = CogGraphicLabelAlignmentConstants.TopLeft;
			rsg.SetXYText(10, 10, e.DataResult["ResultString"]);
			rsg.Color = e.DataResult["Result"] == "1" ? CogColorConstants.Green : CogColorConstants.Red;
			this.Invoke(new Action(() =>
				{
					cogRecordDisplay1.StaticGraphics.Clear();
					cogRecordDisplay1.Record = e.LastRunRecord.SubRecords[0];
					cogRecordDisplay1.StaticGraphics.Add(rsg, "rs");
					string key = "";
					string value = "";
					foreach (int item in cam1Rows)
					{
						key = dataGridView1.Rows[item].Cells[1].Value.ToString();
						e.DataResult.TryGetValue(key, out value);
						dataGridView1.Rows[item].Cells[2].Value = value;
						dataGridView1.Rows[item].Cells[2].Style.BackColor = NGKeys.Contains(key) ? Color.Red : Color.White;
					}
				}));
		}

		void Vision_Cam2ResultAvailable(object sender, VisionResultAvailableEventArgs e)
		{

		}

		void Vision_Cam3ResultAvailable(object sender, VisionResultAvailableEventArgs e)
		{

		}

		private void btnProductName_Click(object sender, EventArgs e)
		{
			if (Globals.runStatus == Globals.RunStatus.Ready && UserManager.GetUserPowLevel(Globals.CurrentUser) > 1)
			{
				Globals.runStatus = Globals.RunStatus.Debug;
				new FrmProductManage().ShowDialog();
				Globals.runStatus = Globals.RunStatus.Ready;
				btnProductName.Text = ProductManager.GetCurProduct().Name;
			}
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			if (Vision.IsAutoRunning())
			{
				btnVisionState.Text = "运行中";
				btnVisionState.BackColor = Color.LimeGreen;
			}
			else
			{
				btnVisionState.Text = "停止";
				btnVisionState.BackColor = Color.DarkSeaGreen;
			}

		}

		private void button1_Click(object sender, EventArgs e)
		{
			SortedList<string, string> rs = Vision.RunCam1Program(Vision.Tb1.Inputs["Image"].Value as Cognex.VisionPro.ICogImage);
			Vision_Cam1ResultAvailable(null, new VisionResultAvailableEventArgs(Vision.Tb1.CreateLastRunRecord(), rs));
		}



	}
}
