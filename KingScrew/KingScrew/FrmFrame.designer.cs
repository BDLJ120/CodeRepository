/*
 * 由SharpDevelop创建。
 * 用户： Administrator
 * 日期: 2018/7/7
 * 时间: 9:48
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace KingScrew
{
	partial class FrmFrame
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		internal System.Windows.Forms.StatusStrip StatusStrip1;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel1;
		internal System.Windows.Forms.ToolStripStatusLabel tsslCurrentUser;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel2;
		internal System.Windows.Forms.ToolStripStatusLabel TSSL_DateTime;
		internal System.Windows.Forms.ToolStripStatusLabel ToolStripStatusLabel3;
		
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFrame));
			this.StatusStrip1 = new System.Windows.Forms.StatusStrip();
			this.ToolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslCurrentUser = new System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslRunStatus = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslMode = new System.Windows.Forms.ToolStripStatusLabel();
			this.ToolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
			this.TSSL_DateTime = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
			this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
			this.tsslMsg = new System.Windows.Forms.ToolStripStatusLabel();
			this.tUpdateUI = new System.Windows.Forms.Timer(this.components);
			this.panelTitle = new System.Windows.Forms.Panel();
			this.btnStop = new System.Windows.Forms.Button();
			this.btnPause = new System.Windows.Forms.Button();
			this.btnRun = new System.Windows.Forms.Button();
			this.btnLog = new System.Windows.Forms.Button();
			this.btnCcd = new System.Windows.Forms.Button();
			this.btnUser = new System.Windows.Forms.Button();
			this.btnMachineId = new System.Windows.Forms.Button();
			this.btnChart = new System.Windows.Forms.Button();
			this.btnAlarm = new System.Windows.Forms.Button();
			this.btnIO = new System.Windows.Forms.Button();
			this.btnSet = new System.Windows.Forms.Button();
			this.btnHome = new System.Windows.Forms.Button();
			this.panelMain = new System.Windows.Forms.Panel();
			this.StatusStrip1.SuspendLayout();
			this.panelTitle.SuspendLayout();
			this.SuspendLayout();
			// 
			// StatusStrip1
			// 
			this.StatusStrip1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.StatusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripStatusLabel1,
            this.tsslCurrentUser,
            this.ToolStripStatusLabel2,
            this.toolStripStatusLabel6,
            this.tsslRunStatus,
            this.toolStripStatusLabel8,
            this.toolStripStatusLabel4,
            this.tsslMode,
            this.ToolStripStatusLabel3,
            this.TSSL_DateTime,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel7,
            this.tsslMsg});
			this.StatusStrip1.Location = new System.Drawing.Point(0, 662);
			this.StatusStrip1.Name = "StatusStrip1";
			this.StatusStrip1.Size = new System.Drawing.Size(1009, 25);
			this.StatusStrip1.TabIndex = 7;
			this.StatusStrip1.Text = "StatusStrip1";
			// 
			// ToolStripStatusLabel1
			// 
			this.ToolStripStatusLabel1.Name = "ToolStripStatusLabel1";
			this.ToolStripStatusLabel1.Size = new System.Drawing.Size(51, 20);
			this.ToolStripStatusLabel1.Text = "用户：";
			// 
			// tsslCurrentUser
			// 
			this.tsslCurrentUser.AutoSize = false;
			this.tsslCurrentUser.BackColor = System.Drawing.Color.Gainsboro;
			this.tsslCurrentUser.Name = "tsslCurrentUser";
			this.tsslCurrentUser.Size = new System.Drawing.Size(80, 20);
			this.tsslCurrentUser.Text = "op";
			// 
			// ToolStripStatusLabel2
			// 
			this.ToolStripStatusLabel2.Name = "ToolStripStatusLabel2";
			this.ToolStripStatusLabel2.Size = new System.Drawing.Size(13, 20);
			this.ToolStripStatusLabel2.Text = "|";
			// 
			// toolStripStatusLabel6
			// 
			this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
			this.toolStripStatusLabel6.Size = new System.Drawing.Size(51, 20);
			this.toolStripStatusLabel6.Text = "状态：";
			// 
			// tsslRunStatus
			// 
			this.tsslRunStatus.AutoSize = false;
			this.tsslRunStatus.BackColor = System.Drawing.Color.Gainsboro;
			this.tsslRunStatus.Name = "tsslRunStatus";
			this.tsslRunStatus.Size = new System.Drawing.Size(80, 20);
			this.tsslRunStatus.Text = "自动";
			// 
			// toolStripStatusLabel8
			// 
			this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
			this.toolStripStatusLabel8.Size = new System.Drawing.Size(13, 20);
			this.toolStripStatusLabel8.Text = "|";
			// 
			// toolStripStatusLabel4
			// 
			this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
			this.toolStripStatusLabel4.Size = new System.Drawing.Size(51, 20);
			this.toolStripStatusLabel4.Text = "模式：";
			// 
			// tsslMode
			// 
			this.tsslMode.AutoSize = false;
			this.tsslMode.BackColor = System.Drawing.Color.Gainsboro;
			this.tsslMode.Name = "tsslMode";
			this.tsslMode.Size = new System.Drawing.Size(120, 20);
			this.tsslMode.Text = "自动";
			// 
			// ToolStripStatusLabel3
			// 
			this.ToolStripStatusLabel3.Name = "ToolStripStatusLabel3";
			this.ToolStripStatusLabel3.Size = new System.Drawing.Size(13, 20);
			this.ToolStripStatusLabel3.Text = "|";
			// 
			// TSSL_DateTime
			// 
			this.TSSL_DateTime.AutoSize = false;
			this.TSSL_DateTime.Name = "TSSL_DateTime";
			this.TSSL_DateTime.Size = new System.Drawing.Size(150, 20);
			this.TSSL_DateTime.Text = "2017.07.05 09:08:00";
			// 
			// toolStripStatusLabel5
			// 
			this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
			this.toolStripStatusLabel5.Size = new System.Drawing.Size(13, 20);
			this.toolStripStatusLabel5.Text = "|";
			// 
			// toolStripStatusLabel7
			// 
			this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
			this.toolStripStatusLabel7.Size = new System.Drawing.Size(51, 20);
			this.toolStripStatusLabel7.Text = "信息：";
			// 
			// tsslMsg
			// 
			this.tsslMsg.BackColor = System.Drawing.Color.Gainsboro;
			this.tsslMsg.Name = "tsslMsg";
			this.tsslMsg.Size = new System.Drawing.Size(37, 20);
			this.tsslMsg.Text = "信息";
			// 
			// tUpdateUI
			// 
			this.tUpdateUI.Tick += new System.EventHandler(this.tUpdateUI_Tick);
			// 
			// panelTitle
			// 
			this.panelTitle.BackColor = System.Drawing.SystemColors.Control;
			this.panelTitle.Controls.Add(this.btnStop);
			this.panelTitle.Controls.Add(this.btnPause);
			this.panelTitle.Controls.Add(this.btnRun);
			this.panelTitle.Controls.Add(this.btnLog);
			this.panelTitle.Controls.Add(this.btnCcd);
			this.panelTitle.Controls.Add(this.btnUser);
			this.panelTitle.Controls.Add(this.btnMachineId);
			this.panelTitle.Controls.Add(this.btnChart);
			this.panelTitle.Controls.Add(this.btnAlarm);
			this.panelTitle.Controls.Add(this.btnIO);
			this.panelTitle.Controls.Add(this.btnSet);
			this.panelTitle.Controls.Add(this.btnHome);
			this.panelTitle.Dock = System.Windows.Forms.DockStyle.Top;
			this.panelTitle.Location = new System.Drawing.Point(0, 0);
			this.panelTitle.Name = "panelTitle";
			this.panelTitle.Size = new System.Drawing.Size(1009, 70);
			this.panelTitle.TabIndex = 16;
			this.panelTitle.DoubleClick += new System.EventHandler(this.panelTitle_DoubleClick);
			// 
			// btnStop
			// 
			this.btnStop.BackColor = System.Drawing.Color.Gainsboro;
			this.btnStop.BackgroundImage = global::KingScrew.Properties.Resources.stop;
			this.btnStop.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnStop.FlatAppearance.BorderSize = 0;
			this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnStop.Location = new System.Drawing.Point(705, 5);
			this.btnStop.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(60, 60);
			this.btnStop.TabIndex = 25;
			this.btnStop.TabStop = false;
			this.btnStop.Tag = "2";
			this.btnStop.UseVisualStyleBackColor = false;
			this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
			// 
			// btnPause
			// 
			this.btnPause.BackColor = System.Drawing.Color.Gainsboro;
			this.btnPause.BackgroundImage = global::KingScrew.Properties.Resources.pause;
			this.btnPause.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnPause.Enabled = false;
			this.btnPause.FlatAppearance.BorderSize = 0;
			this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnPause.Location = new System.Drawing.Point(640, 5);
			this.btnPause.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.btnPause.Name = "btnPause";
			this.btnPause.Size = new System.Drawing.Size(60, 60);
			this.btnPause.TabIndex = 24;
			this.btnPause.TabStop = false;
			this.btnPause.UseVisualStyleBackColor = false;
			// 
			// btnRun
			// 
			this.btnRun.BackColor = System.Drawing.Color.Gainsboro;
			this.btnRun.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRun.BackgroundImage")));
			this.btnRun.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnRun.FlatAppearance.BorderSize = 0;
			this.btnRun.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRun.Location = new System.Drawing.Point(575, 5);
			this.btnRun.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.btnRun.Name = "btnRun";
			this.btnRun.Size = new System.Drawing.Size(60, 60);
			this.btnRun.TabIndex = 23;
			this.btnRun.TabStop = false;
			this.btnRun.Tag = "2";
			this.btnRun.UseVisualStyleBackColor = false;
			this.btnRun.Click += new System.EventHandler(this.btnRun_Click);
			// 
			// btnLog
			// 
			this.btnLog.BackColor = System.Drawing.Color.Gainsboro;
			this.btnLog.BackgroundImage = global::KingScrew.Properties.Resources.log;
			this.btnLog.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnLog.FlatAppearance.BorderSize = 0;
			this.btnLog.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnLog.Location = new System.Drawing.Point(814, 5);
			this.btnLog.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.btnLog.Name = "btnLog";
			this.btnLog.Size = new System.Drawing.Size(60, 60);
			this.btnLog.TabIndex = 22;
			this.btnLog.TabStop = false;
			this.btnLog.UseVisualStyleBackColor = false;
			this.btnLog.Click += new System.EventHandler(this.btnLog_Click);
			// 
			// btnCcd
			// 
			this.btnCcd.BackColor = System.Drawing.Color.Gainsboro;
			this.btnCcd.BackgroundImage = global::KingScrew.Properties.Resources.ccd;
			this.btnCcd.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnCcd.FlatAppearance.BorderSize = 0;
			this.btnCcd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCcd.Location = new System.Drawing.Point(879, 5);
			this.btnCcd.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.btnCcd.Name = "btnCcd";
			this.btnCcd.Size = new System.Drawing.Size(60, 60);
			this.btnCcd.TabIndex = 21;
			this.btnCcd.TabStop = false;
			this.btnCcd.Tag = "2";
			this.btnCcd.UseVisualStyleBackColor = false;
			this.btnCcd.Click += new System.EventHandler(this.btnCcd_Click);
			// 
			// btnUser
			// 
			this.btnUser.BackColor = System.Drawing.Color.Gainsboro;
			this.btnUser.BackgroundImage = global::KingScrew.Properties.Resources.user;
			this.btnUser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnUser.FlatAppearance.BorderSize = 0;
			this.btnUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUser.Location = new System.Drawing.Point(944, 5);
			this.btnUser.Margin = new System.Windows.Forms.Padding(5);
			this.btnUser.Name = "btnUser";
			this.btnUser.Size = new System.Drawing.Size(60, 60);
			this.btnUser.TabIndex = 20;
			this.btnUser.TabStop = false;
			this.btnUser.UseVisualStyleBackColor = false;
			this.btnUser.Click += new System.EventHandler(this.btnUser_Click);
			// 
			// btnMachineId
			// 
			this.btnMachineId.BackColor = System.Drawing.Color.Gainsboro;
			this.btnMachineId.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnMachineId.FlatAppearance.BorderSize = 0;
			this.btnMachineId.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnMachineId.Font = new System.Drawing.Font("微软雅黑", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnMachineId.Location = new System.Drawing.Point(330, 5);
			this.btnMachineId.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.btnMachineId.Name = "btnMachineId";
			this.btnMachineId.Size = new System.Drawing.Size(240, 60);
			this.btnMachineId.TabIndex = 20;
			this.btnMachineId.TabStop = false;
			this.btnMachineId.Text = "Machine ID";
			this.btnMachineId.UseVisualStyleBackColor = false;
			// 
			// btnChart
			// 
			this.btnChart.BackColor = System.Drawing.Color.Gainsboro;
			this.btnChart.BackgroundImage = global::KingScrew.Properties.Resources.chart;
			this.btnChart.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnChart.FlatAppearance.BorderSize = 0;
			this.btnChart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnChart.Location = new System.Drawing.Point(265, 5);
			this.btnChart.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.btnChart.Name = "btnChart";
			this.btnChart.Size = new System.Drawing.Size(60, 60);
			this.btnChart.TabIndex = 19;
			this.btnChart.TabStop = false;
			this.btnChart.UseVisualStyleBackColor = false;
			this.btnChart.Click += new System.EventHandler(this.btnChart_Click);
			// 
			// btnAlarm
			// 
			this.btnAlarm.BackColor = System.Drawing.Color.Gainsboro;
			this.btnAlarm.BackgroundImage = global::KingScrew.Properties.Resources.alarm;
			this.btnAlarm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnAlarm.FlatAppearance.BorderSize = 0;
			this.btnAlarm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnAlarm.Location = new System.Drawing.Point(200, 5);
			this.btnAlarm.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.btnAlarm.Name = "btnAlarm";
			this.btnAlarm.Size = new System.Drawing.Size(60, 60);
			this.btnAlarm.TabIndex = 18;
			this.btnAlarm.TabStop = false;
			this.btnAlarm.UseVisualStyleBackColor = false;
			// 
			// btnIO
			// 
			this.btnIO.BackColor = System.Drawing.Color.Gainsboro;
			this.btnIO.BackgroundImage = global::KingScrew.Properties.Resources.io;
			this.btnIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnIO.FlatAppearance.BorderSize = 0;
			this.btnIO.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnIO.Location = new System.Drawing.Point(135, 5);
			this.btnIO.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.btnIO.Name = "btnIO";
			this.btnIO.Size = new System.Drawing.Size(60, 60);
			this.btnIO.TabIndex = 17;
			this.btnIO.TabStop = false;
			this.btnIO.UseVisualStyleBackColor = false;
			// 
			// btnSet
			// 
			this.btnSet.BackColor = System.Drawing.Color.Gainsboro;
			this.btnSet.BackgroundImage = global::KingScrew.Properties.Resources.setting;
			this.btnSet.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnSet.Enabled = false;
			this.btnSet.FlatAppearance.BorderSize = 0;
			this.btnSet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSet.Location = new System.Drawing.Point(70, 5);
			this.btnSet.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.btnSet.Name = "btnSet";
			this.btnSet.Size = new System.Drawing.Size(60, 60);
			this.btnSet.TabIndex = 16;
			this.btnSet.TabStop = false;
			this.btnSet.Tag = "1";
			this.btnSet.UseVisualStyleBackColor = false;
			this.btnSet.Click += new System.EventHandler(this.btnSet_Click);
			// 
			// btnHome
			// 
			this.btnHome.BackColor = System.Drawing.Color.Gainsboro;
			this.btnHome.BackgroundImage = global::KingScrew.Properties.Resources.home;
			this.btnHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnHome.FlatAppearance.BorderSize = 0;
			this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnHome.Location = new System.Drawing.Point(5, 5);
			this.btnHome.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.btnHome.Name = "btnHome";
			this.btnHome.Size = new System.Drawing.Size(60, 60);
			this.btnHome.TabIndex = 15;
			this.btnHome.TabStop = false;
			this.btnHome.UseVisualStyleBackColor = false;
			this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
			// 
			// panelMain
			// 
			this.panelMain.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panelMain.Location = new System.Drawing.Point(0, 70);
			this.panelMain.Name = "panelMain";
			this.panelMain.Size = new System.Drawing.Size(1009, 592);
			this.panelMain.TabIndex = 17;
			// 
			// FrmFrame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.WhiteSmoke;
			this.ClientSize = new System.Drawing.Size(1009, 687);
			this.Controls.Add(this.panelMain);
			this.Controls.Add(this.panelTitle);
			this.Controls.Add(this.StatusStrip1);
			this.IsMdiContainer = true;
			this.MaximizeBox = false;
			this.Name = "FrmFrame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "YMachineUI";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmFrame_FormClosing);
			this.Load += new System.EventHandler(this.MainFormLoad);
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			this.panelTitle.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}
		private System.Windows.Forms.Timer tUpdateUI;
		private System.Windows.Forms.ToolStripStatusLabel tsslMsg;
        private System.Windows.Forms.ToolStripStatusLabel tsslRunStatus;
		internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
		private System.Windows.Forms.Button btnHome;
		private System.Windows.Forms.Panel panelTitle;
		private System.Windows.Forms.Button btnSet;
		private System.Windows.Forms.Panel panelMain;
		private System.Windows.Forms.Button btnIO;
		private System.Windows.Forms.Button btnUser;
		private System.Windows.Forms.Button btnMachineId;
		private System.Windows.Forms.Button btnChart;
		private System.Windows.Forms.Button btnAlarm;
		private System.Windows.Forms.Button btnLog;
		private System.Windows.Forms.Button btnCcd;
		private System.Windows.Forms.Button btnRun;
		private System.Windows.Forms.Button btnPause;
		private System.Windows.Forms.Button btnStop;
		internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
		internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
		internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
		private System.Windows.Forms.ToolStripStatusLabel tsslMode;
		internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
    }
}
