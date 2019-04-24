using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KingScrew
{
	public partial class MsgBox : Form
	{
		private DialogResult Result;
		private DialogResult Yes = DialogResult.Yes;
		private DialogResult No = DialogResult.No;
		private DialogResult Cancel = DialogResult.Cancel;

		public static DialogResult Show(string message, MessageBoxButtons buttons = MessageBoxButtons.OK, MessageBoxIcon ico = MessageBoxIcon.Information)
		{
			MsgBox frm = new MsgBox();
			frm.SetIco(ico);
			frm.SetButton(buttons);
			frm.lbMsg.Text = message;
			frm.ShowDialog();
			return frm.Result;
		}

		private void SetIco(MessageBoxIcon ico)
		{
			string key = "Information";
			switch (ico)
			{
				case MessageBoxIcon.None:
					break;
				case MessageBoxIcon.Error:
					key = "Error";
					break;
				case MessageBoxIcon.Question:
					key = "Question";
					break;
				case MessageBoxIcon.Warning:
					key = "Warning";
					break;
				case MessageBoxIcon.Information:
					key = "Information";
					break;
				default:
					break;
			}
			pic.Image = icos.Images[key];
		}

		private void SetButton(MessageBoxButtons buttons)
		{
			switch (buttons)
			{
				case MessageBoxButtons.OK:
					btnYes.Text = "确定";
					btnYes.Visible = true;
					Yes = System.Windows.Forms.DialogResult.OK;
					break;
				case MessageBoxButtons.OKCancel:
					btnYes.Text = "确定";
					btnYes.Visible = true;
					Yes = System.Windows.Forms.DialogResult.OK;
					btnNo.Text = "取消";
					btnNo.Visible = true;
					No = System.Windows.Forms.DialogResult.Cancel;
					break;
				case MessageBoxButtons.AbortRetryIgnore:
					btnYes.Text = "放弃";
					btnYes.Visible = true;
					Yes = System.Windows.Forms.DialogResult.Abort;
					btnNo.Text = "重试";
					btnNo.Visible = true;
					No = System.Windows.Forms.DialogResult.Retry;
					btnCancel.Text = "忽略";
					btnCancel.Visible = true;
					Cancel = System.Windows.Forms.DialogResult.Ignore;
					break;
				case MessageBoxButtons.YesNoCancel:
					btnYes.Text = "是";
					btnYes.Visible = true;
					Yes = System.Windows.Forms.DialogResult.Yes;
					btnNo.Text = "否";
					btnNo.Visible = true;
					No = System.Windows.Forms.DialogResult.No;
					btnCancel.Text = "取消";
					btnCancel.Visible = true;
					Cancel = System.Windows.Forms.DialogResult.Cancel;
					break;
				case MessageBoxButtons.YesNo:
					btnYes.Text = "是";
					btnYes.Visible = true;
					Yes = System.Windows.Forms.DialogResult.Yes;
					btnNo.Text = "否";
					btnNo.Visible = true;
					No = System.Windows.Forms.DialogResult.No;
					break;
				case MessageBoxButtons.RetryCancel:
					btnYes.Text = "重试";
					btnYes.Visible = true;
					Yes = System.Windows.Forms.DialogResult.Retry;
					btnNo.Text = "取消";
					btnNo.Visible = true;
					No = System.Windows.Forms.DialogResult.Cancel;
					break;
				default:
					break;
			}
		}

		public MsgBox()
		{
			InitializeComponent();
		}

		private void MsgBox_Load(object sender, EventArgs e)
		{

		}

		private void btnYes_Click(object sender, EventArgs e)
		{
			Result = Yes;
			Close();
		}

		private void btnNo_Click(object sender, EventArgs e)
		{
			Result = No;
			Close();
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Result = Cancel;
			Close();
		}


	}
}
