/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2018/7/7
 * 时间: 9:52
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace KingScrew
{
	partial class FrmUser
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		internal System.Windows.Forms.TextBox Tb_pwd;
		internal System.Windows.Forms.Label Label3;
		internal System.Windows.Forms.Label Label2;
		internal System.Windows.Forms.TextBox txtNewPwd;
		internal System.Windows.Forms.Label Label5;
		internal System.Windows.Forms.TextBox txtOldPwd;
		internal System.Windows.Forms.Label Label4;
		internal System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox combUserName;
		private System.Windows.Forms.ComboBox combUserName2;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnModify = new System.Windows.Forms.Button();
			this.btnLogin = new System.Windows.Forms.Button();
			this.panelMode = new System.Windows.Forms.Panel();
			this.btnCpkGrrMode = new System.Windows.Forms.Button();
			this.btnEngineeringMode = new System.Windows.Forms.Button();
			this.btnProductionMode = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.tabContainer1 = new KingScrew.Utilities.TabContainer();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.combUserName = new System.Windows.Forms.ComboBox();
			this.Bt_Logout = new System.Windows.Forms.Button();
			this.Label2 = new System.Windows.Forms.Label();
			this.Bt_Login = new System.Windows.Forms.Button();
			this.Label3 = new System.Windows.Forms.Label();
			this.Tb_pwd = new System.Windows.Forms.TextBox();
			this.tabPage4 = new System.Windows.Forms.TabPage();
			this.combUserName2 = new System.Windows.Forms.ComboBox();
			this.Bt_modify = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txtNewPwd = new System.Windows.Forms.TextBox();
			this.Label4 = new System.Windows.Forms.Label();
			this.Label5 = new System.Windows.Forms.Label();
			this.txtOldPwd = new System.Windows.Forms.TextBox();
			this.panel2.SuspendLayout();
			this.panel3.SuspendLayout();
			this.panelMode.SuspendLayout();
			this.tabContainer1.SuspendLayout();
			this.tabPage3.SuspendLayout();
			this.tabPage4.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel2
			// 
			this.panel2.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel2.Controls.Add(this.panel3);
			this.panel2.Controls.Add(this.tabContainer1);
			this.panel2.Location = new System.Drawing.Point(685, 8);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(300, 300);
			this.panel2.TabIndex = 17;
			// 
			// panel3
			// 
			this.panel3.Controls.Add(this.btnModify);
			this.panel3.Controls.Add(this.btnLogin);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(300, 70);
			this.panel3.TabIndex = 0;
			// 
			// btnModify
			// 
			this.btnModify.BackColor = System.Drawing.Color.Gainsboro;
			this.btnModify.BackgroundImage = global::KingScrew.Properties.Resources.key;
			this.btnModify.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnModify.FlatAppearance.BorderSize = 0;
			this.btnModify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnModify.Location = new System.Drawing.Point(70, 5);
			this.btnModify.Margin = new System.Windows.Forms.Padding(5);
			this.btnModify.Name = "btnModify";
			this.btnModify.Size = new System.Drawing.Size(60, 60);
			this.btnModify.TabIndex = 22;
			this.btnModify.TabStop = false;
			this.btnModify.UseVisualStyleBackColor = false;
			this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
			// 
			// btnLogin
			// 
			this.btnLogin.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.btnLogin.BackgroundImage = global::KingScrew.Properties.Resources.login;
			this.btnLogin.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnLogin.FlatAppearance.BorderSize = 0;
			this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLogin.Location = new System.Drawing.Point(5, 5);
			this.btnLogin.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.btnLogin.Name = "btnLogin";
			this.btnLogin.Size = new System.Drawing.Size(60, 60);
			this.btnLogin.TabIndex = 21;
			this.btnLogin.TabStop = false;
			this.btnLogin.UseVisualStyleBackColor = false;
			this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
			// 
			// panelMode
			// 
			this.panelMode.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panelMode.Controls.Add(this.btnCpkGrrMode);
			this.panelMode.Controls.Add(this.btnEngineeringMode);
			this.panelMode.Controls.Add(this.btnProductionMode);
			this.panelMode.Location = new System.Drawing.Point(8, 78);
			this.panelMode.Name = "panelMode";
			this.panelMode.Size = new System.Drawing.Size(671, 471);
			this.panelMode.TabIndex = 18;
			// 
			// btnCpkGrrMode
			// 
			this.btnCpkGrrMode.BackColor = System.Drawing.Color.Gainsboro;
			this.btnCpkGrrMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnCpkGrrMode.FlatAppearance.BorderSize = 0;
			this.btnCpkGrrMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCpkGrrMode.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnCpkGrrMode.Location = new System.Drawing.Point(149, 218);
			this.btnCpkGrrMode.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.btnCpkGrrMode.Name = "btnCpkGrrMode";
			this.btnCpkGrrMode.Size = new System.Drawing.Size(300, 60);
			this.btnCpkGrrMode.TabIndex = 23;
			this.btnCpkGrrMode.TabStop = false;
			this.btnCpkGrrMode.Tag = "1";
			this.btnCpkGrrMode.Text = "CPK/GRR Mode";
			this.btnCpkGrrMode.UseVisualStyleBackColor = false;
			this.btnCpkGrrMode.Click += new System.EventHandler(this.btnCpkGrrMode_Click);
			// 
			// btnEngineeringMode
			// 
			this.btnEngineeringMode.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.btnEngineeringMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnEngineeringMode.FlatAppearance.BorderSize = 0;
			this.btnEngineeringMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEngineeringMode.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnEngineeringMode.Location = new System.Drawing.Point(149, 148);
			this.btnEngineeringMode.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.btnEngineeringMode.Name = "btnEngineeringMode";
			this.btnEngineeringMode.Size = new System.Drawing.Size(300, 60);
			this.btnEngineeringMode.TabIndex = 22;
			this.btnEngineeringMode.TabStop = false;
			this.btnEngineeringMode.Tag = "2";
			this.btnEngineeringMode.Text = "Engineering Mode";
			this.btnEngineeringMode.UseVisualStyleBackColor = false;
			this.btnEngineeringMode.Click += new System.EventHandler(this.btnEngineeringMode_Click);
			// 
			// btnProductionMode
			// 
			this.btnProductionMode.BackColor = System.Drawing.Color.Gainsboro;
			this.btnProductionMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnProductionMode.FlatAppearance.BorderSize = 0;
			this.btnProductionMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProductionMode.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnProductionMode.Location = new System.Drawing.Point(149, 78);
			this.btnProductionMode.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.btnProductionMode.Name = "btnProductionMode";
			this.btnProductionMode.Size = new System.Drawing.Size(300, 60);
			this.btnProductionMode.TabIndex = 21;
			this.btnProductionMode.TabStop = false;
			this.btnProductionMode.Tag = "0";
			this.btnProductionMode.Text = "Production Mode";
			this.btnProductionMode.UseVisualStyleBackColor = false;
			this.btnProductionMode.Click += new System.EventHandler(this.btnProductionMode_Click);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// tabContainer1
			// 
			this.tabContainer1.Alignment = System.Windows.Forms.TabAlignment.Bottom;
			this.tabContainer1.Controls.Add(this.tabPage3);
			this.tabContainer1.Controls.Add(this.tabPage4);
			this.tabContainer1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tabContainer1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tabContainer1.ItemSize = new System.Drawing.Size(80, 10);
			this.tabContainer1.Location = new System.Drawing.Point(5, 70);
			this.tabContainer1.MainBackColor = System.Drawing.Color.Gainsboro;
			this.tabContainer1.Name = "tabContainer1";
			this.tabContainer1.SelectedIndex = 0;
			this.tabContainer1.Size = new System.Drawing.Size(292, 218);
			this.tabContainer1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabContainer1.TabIndex = 15;
			this.tabContainer1.TitleColor = System.Drawing.Color.Gainsboro;
			this.tabContainer1.TitleFont = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.tabContainer1.TitleForceColor = System.Drawing.Color.Black;
			this.tabContainer1.TitleHorizontalAlignment = System.Drawing.StringAlignment.Center;
			this.tabContainer1.TitleSelectedColor = System.Drawing.Color.Gainsboro;
			this.tabContainer1.TitleVerticalAlignment = System.Drawing.StringAlignment.Center;
			this.tabContainer1.Selecting += new System.Windows.Forms.TabControlCancelEventHandler(this.tabContainer1_Selecting);
			// 
			// tabPage3
			// 
			this.tabPage3.BackColor = System.Drawing.Color.Gainsboro;
			this.tabPage3.Controls.Add(this.combUserName);
			this.tabPage3.Controls.Add(this.Bt_Logout);
			this.tabPage3.Controls.Add(this.Label2);
			this.tabPage3.Controls.Add(this.Bt_Login);
			this.tabPage3.Controls.Add(this.Label3);
			this.tabPage3.Controls.Add(this.Tb_pwd);
			this.tabPage3.Location = new System.Drawing.Point(4, 4);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(284, 200);
			this.tabPage3.TabIndex = 0;
			// 
			// combUserName
			// 
			this.combUserName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.combUserName.FormattingEnabled = true;
			this.combUserName.Location = new System.Drawing.Point(85, 20);
			this.combUserName.Name = "combUserName";
			this.combUserName.Size = new System.Drawing.Size(180, 28);
			this.combUserName.TabIndex = 9;
			// 
			// Bt_Logout
			// 
			this.Bt_Logout.BackColor = System.Drawing.Color.DarkOrange;
			this.Bt_Logout.FlatAppearance.BorderSize = 0;
			this.Bt_Logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Bt_Logout.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Bt_Logout.Location = new System.Drawing.Point(185, 130);
			this.Bt_Logout.Name = "Bt_Logout";
			this.Bt_Logout.Size = new System.Drawing.Size(80, 40);
			this.Bt_Logout.TabIndex = 8;
			this.Bt_Logout.TabStop = false;
			this.Bt_Logout.Text = "登出";
			this.Bt_Logout.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Bt_Logout.UseVisualStyleBackColor = false;
			this.Bt_Logout.Click += new System.EventHandler(this.Bt_Logout_Click);
			// 
			// Label2
			// 
			this.Label2.AutoSize = true;
			this.Label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Label2.Location = new System.Drawing.Point(25, 23);
			this.Label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.Label2.Name = "Label2";
			this.Label2.Size = new System.Drawing.Size(51, 20);
			this.Label2.TabIndex = 3;
			this.Label2.Text = "用户：";
			// 
			// Bt_Login
			// 
			this.Bt_Login.BackColor = System.Drawing.Color.DarkOrange;
			this.Bt_Login.FlatAppearance.BorderSize = 0;
			this.Bt_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Bt_Login.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Bt_Login.Location = new System.Drawing.Point(85, 130);
			this.Bt_Login.Name = "Bt_Login";
			this.Bt_Login.Size = new System.Drawing.Size(80, 40);
			this.Bt_Login.TabIndex = 7;
			this.Bt_Login.TabStop = false;
			this.Bt_Login.Text = "登录";
			this.Bt_Login.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Bt_Login.UseVisualStyleBackColor = false;
			this.Bt_Login.Click += new System.EventHandler(this.Bt_Login_Click);
			// 
			// Label3
			// 
			this.Label3.AutoSize = true;
			this.Label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Label3.Location = new System.Drawing.Point(25, 74);
			this.Label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.Label3.Name = "Label3";
			this.Label3.Size = new System.Drawing.Size(51, 20);
			this.Label3.TabIndex = 4;
			this.Label3.Text = "密码：";
			// 
			// Tb_pwd
			// 
			this.Tb_pwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Tb_pwd.Location = new System.Drawing.Point(85, 71);
			this.Tb_pwd.Name = "Tb_pwd";
			this.Tb_pwd.PasswordChar = '*';
			this.Tb_pwd.Size = new System.Drawing.Size(180, 26);
			this.Tb_pwd.TabIndex = 5;
			// 
			// tabPage4
			// 
			this.tabPage4.BackColor = System.Drawing.Color.Gainsboro;
			this.tabPage4.Controls.Add(this.combUserName2);
			this.tabPage4.Controls.Add(this.Bt_modify);
			this.tabPage4.Controls.Add(this.label1);
			this.tabPage4.Controls.Add(this.txtNewPwd);
			this.tabPage4.Controls.Add(this.Label4);
			this.tabPage4.Controls.Add(this.Label5);
			this.tabPage4.Controls.Add(this.txtOldPwd);
			this.tabPage4.ImageIndex = 0;
			this.tabPage4.Location = new System.Drawing.Point(4, 4);
			this.tabPage4.Name = "tabPage4";
			this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage4.Size = new System.Drawing.Size(284, 200);
			this.tabPage4.TabIndex = 1;
			// 
			// combUserName2
			// 
			this.combUserName2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.combUserName2.FormattingEnabled = true;
			this.combUserName2.Location = new System.Drawing.Point(85, 20);
			this.combUserName2.Name = "combUserName2";
			this.combUserName2.Size = new System.Drawing.Size(180, 28);
			this.combUserName2.TabIndex = 14;
			// 
			// Bt_modify
			// 
			this.Bt_modify.BackColor = System.Drawing.Color.DarkOrange;
			this.Bt_modify.FlatAppearance.BorderSize = 0;
			this.Bt_modify.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.Bt_modify.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Bt_modify.Location = new System.Drawing.Point(85, 130);
			this.Bt_modify.Name = "Bt_modify";
			this.Bt_modify.Size = new System.Drawing.Size(80, 40);
			this.Bt_modify.TabIndex = 10;
			this.Bt_modify.TabStop = false;
			this.Bt_modify.Text = "修改";
			this.Bt_modify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.Bt_modify.UseVisualStyleBackColor = false;
			this.Bt_modify.Click += new System.EventHandler(this.Bt_modify_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(11, 23);
			this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 20);
			this.label1.TabIndex = 13;
			this.label1.Text = "用户名：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtNewPwd
			// 
			this.txtNewPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtNewPwd.Location = new System.Drawing.Point(85, 90);
			this.txtNewPwd.Name = "txtNewPwd";
			this.txtNewPwd.PasswordChar = '*';
			this.txtNewPwd.Size = new System.Drawing.Size(180, 26);
			this.txtNewPwd.TabIndex = 12;
			// 
			// Label4
			// 
			this.Label4.AutoSize = true;
			this.Label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Label4.Location = new System.Drawing.Point(11, 59);
			this.Label4.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.Label4.Name = "Label4";
			this.Label4.Size = new System.Drawing.Size(65, 20);
			this.Label4.TabIndex = 8;
			this.Label4.Text = "旧密码：";
			this.Label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Label5
			// 
			this.Label5.AutoSize = true;
			this.Label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Label5.Location = new System.Drawing.Point(11, 93);
			this.Label5.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
			this.Label5.Name = "Label5";
			this.Label5.Size = new System.Drawing.Size(65, 20);
			this.Label5.TabIndex = 11;
			this.Label5.Text = "新密码：";
			this.Label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// txtOldPwd
			// 
			this.txtOldPwd.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.txtOldPwd.Location = new System.Drawing.Point(85, 56);
			this.txtOldPwd.Name = "txtOldPwd";
			this.txtOldPwd.PasswordChar = '*';
			this.txtOldPwd.Size = new System.Drawing.Size(180, 26);
			this.txtOldPwd.TabIndex = 9;
			// 
			// FrmUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(993, 557);
			this.ControlBox = false;
			this.Controls.Add(this.panelMode);
			this.Controls.Add(this.panel2);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmUser";
			this.Padding = new System.Windows.Forms.Padding(5);
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Load += new System.EventHandler(this.FrmUserLoad);
			this.panel2.ResumeLayout(false);
			this.panel3.ResumeLayout(false);
			this.panelMode.ResumeLayout(false);
			this.tabContainer1.ResumeLayout(false);
			this.tabPage3.ResumeLayout(false);
			this.tabPage3.PerformLayout();
			this.tabPage4.ResumeLayout(false);
			this.tabPage4.PerformLayout();
			this.ResumeLayout(false);

		}
		internal System.Windows.Forms.Button Bt_Logout;
		internal System.Windows.Forms.Button Bt_Login;
		internal System.Windows.Forms.Button Bt_modify;
		private System.Windows.Forms.TabPage tabPage4;
		private System.Windows.Forms.TabPage tabPage3;
		private Utilities.TabContainer tabContainer1;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnModify;
		private System.Windows.Forms.Button btnLogin;
		private System.Windows.Forms.Panel panelMode;
		private System.Windows.Forms.Button btnCpkGrrMode;
		private System.Windows.Forms.Button btnEngineeringMode;
		private System.Windows.Forms.Button btnProductionMode;
		private System.Windows.Forms.Timer timer1;
	}
}
