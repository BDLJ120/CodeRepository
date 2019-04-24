/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2018/7/7
 * 时间: 9:52
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
using System;
using System.Drawing;
using System.Windows.Forms;

namespace KingScrew
{
	/// <summary>
	/// Description of FrmUser.
	/// </summary>
	public partial class FrmUser : Form
	{
		private int selectedIndex = 0;

		public FrmUser()
		{
			InitializeComponent();
			Label lbCover = new Label();
			lbCover.BackColor = tabContainer1.MainBackColor;
			lbCover.AutoSize = false;
			lbCover.Text = "";
			lbCover.Height = tabContainer1.ItemSize.Height + 10;
			lbCover.Width = tabContainer1.Width - 10;
			lbCover.Location = new Point(tabContainer1.Location.X, tabContainer1.Location.Y + tabContainer1.Size.Height - lbCover.Size.Height);
			panel2.Controls.Add(lbCover);
			lbCover.BringToFront();
		}

		void FrmUserLoad(object sender, EventArgs e)
		{
			combUserName.Items.Clear();
			combUserName.Items.AddRange(UserManager.GetAllUserNames().ToArray());
			combUserName.SelectedItem = Globals.CurrentUser;
			combUserName2.Items.Clear();
			combUserName2.Items.AddRange(UserManager.GetAllUserNames().ToArray());
			combUserName2.SelectedItem = Globals.CurrentUser;

			btnProductionMode.Text = EnumDescription.GetFieldText(Globals.RunMode.ProductionMode);
			btnEngineeringMode.Text = EnumDescription.GetFieldText(Globals.RunMode.EngineeringMode);
			btnCpkGrrMode.Text = EnumDescription.GetFieldText(Globals.RunMode.CpkGrrMode);
			Globals.SetControlsEnable(panelMode);
		}

		private void tabContainer1_Selecting(object sender, TabControlCancelEventArgs e)
		{
			tabContainer1.SelectedIndex = selectedIndex;
		}

		private void btnLogin_Click(object sender, EventArgs e)
		{
			btnLogin.BackColor = Color.DarkSeaGreen;
			btnModify.BackColor = Color.Gainsboro;
			SetPage(0);
		}

		private void btnModify_Click(object sender, EventArgs e)
		{
			btnModify.BackColor = Color.DarkSeaGreen;
			btnLogin.BackColor = Color.Gainsboro;
			SetPage(1);
		}

		private void SetPage(int index)
		{
			selectedIndex = index;
			tabContainer1.SelectedIndex = index;
		}

		private void Bt_Login_Click(object sender, EventArgs e)
		{
			if (Globals.CurrentUser == combUserName.Text)
			{
				return;
			}
			string rs = UserManager.CheckIn(combUserName.Text, Tb_pwd.Text);
			if (rs == "OK")
			{
				Tb_pwd.Text = "";
				MsgBox.Show("登录成功！", ico: MessageBoxIcon.Information);
				Globals.CurrentUser = combUserName.Text;
				Globals.SetControlsEnable(panelMode);
			}
			else
			{
				MsgBox.Show(rs, ico: MessageBoxIcon.Warning);
			}
		}

		private void Bt_Logout_Click(object sender, EventArgs e)
		{
			Globals.CurrentUser = "操作员";
			Globals.SetControlsEnable(panelMode);
		}

		private void Bt_modify_Click(object sender, EventArgs e)
		{
			string rs = UserManager.ModifyPassword(combUserName2.Text, txtOldPwd.Text, txtNewPwd.Text);
			if (rs == "OK")
			{
				txtOldPwd.Text = "";
				txtNewPwd.Text = "";
				Globals.MLog.Info(string.Format("用户 [{0}] 修改密码", Globals.CurrentUser));
				MsgBox.Show("修改成功！", ico: MessageBoxIcon.Information);
			}
			else
			{
				MsgBox.Show(rs, ico: MessageBoxIcon.Warning);
			}
		}

		private void btnProductionMode_Click(object sender, EventArgs e)
		{
			Globals.CurrentRunMode = Globals.RunMode.ProductionMode;
		}

		private void btnEngineeringMode_Click(object sender, EventArgs e)
		{
			Globals.CurrentRunMode = Globals.RunMode.EngineeringMode;
		}

		private void btnCpkGrrMode_Click(object sender, EventArgs e)
		{
			Globals.CurrentRunMode = Globals.RunMode.CpkGrrMode;
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			switch (Globals.CurrentRunMode)
			{
				case Globals.RunMode.ProductionMode:
					btnProductionMode.BackColor = Color.DarkSeaGreen;
					btnEngineeringMode.BackColor = Color.Gainsboro;
					btnCpkGrrMode.BackColor = Color.Gainsboro;
					break;
				case Globals.RunMode.EngineeringMode:
					btnProductionMode.BackColor = Color.Gainsboro;
					btnEngineeringMode.BackColor = Color.DarkSeaGreen;
					btnCpkGrrMode.BackColor = Color.Gainsboro;
					break;
				case Globals.RunMode.CpkGrrMode:
					btnProductionMode.BackColor = Color.Gainsboro;
					btnEngineeringMode.BackColor = Color.Gainsboro;
					btnCpkGrrMode.BackColor = Color.DarkSeaGreen;
					break;
				default:
					break;
			}
		}
	}
}
