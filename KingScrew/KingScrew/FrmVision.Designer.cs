namespace KingScrew
{
	partial class FrmVision
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
			this.tabContainer1 = new KingScrew.Utilities.TabContainer();
			this.tabPage1 = new System.Windows.Forms.TabPage();
			this.btnRun1 = new System.Windows.Forms.Button();
			this.btnOpen1 = new System.Windows.Forms.Button();
			this.btnShot1 = new System.Windows.Forms.Button();
			this.cogToolBlockEditV21 = new Cognex.VisionPro.ToolBlock.CogToolBlockEditV2();
			this.btnSave1 = new System.Windows.Forms.Button();
			this.tabPage2 = new System.Windows.Forms.TabPage();
			this.btnRun2 = new System.Windows.Forms.Button();
			this.btnOpen2 = new System.Windows.Forms.Button();
			this.btnShot2 = new System.Windows.Forms.Button();
			this.btnSave2 = new System.Windows.Forms.Button();
			this.cogToolBlockEditV22 = new Cognex.VisionPro.ToolBlock.CogToolBlockEditV2();
			this.tabPage3 = new System.Windows.Forms.TabPage();
			this.btnOpen3 = new System.Windows.Forms.Button();
			this.btnShot3 = new System.Windows.Forms.Button();
			this.btnSave3 = new System.Windows.Forms.Button();
			this.cogToolBlockEditV23 = new Cognex.VisionPro.ToolBlock.CogToolBlockEditV2();
			this.btnRun3 = new System.Windows.Forms.Button();
			this.tabContainer1.SuspendLayout();
			this.tabPage1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEditV21)).BeginInit();
			this.tabPage2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEditV22)).BeginInit();
			this.tabPage3.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEditV23)).BeginInit();
			this.SuspendLayout();
			// 
			// openFileDialog1
			// 
			this.openFileDialog1.FileName = "Image01";
			this.openFileDialog1.Filter = "图像文件|*.bmp;*.png;*.jpg";
			this.openFileDialog1.Title = "打开图像...";
			// 
			// tabContainer1
			// 
			this.tabContainer1.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
			this.tabContainer1.Controls.Add(this.tabPage1);
			this.tabContainer1.Controls.Add(this.tabPage2);
			this.tabContainer1.Controls.Add(this.tabPage3);
			this.tabContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabContainer1.DrawMode = System.Windows.Forms.TabDrawMode.OwnerDrawFixed;
			this.tabContainer1.ItemSize = new System.Drawing.Size(100, 40);
			this.tabContainer1.Location = new System.Drawing.Point(0, 0);
			this.tabContainer1.MainBackColor = System.Drawing.Color.WhiteSmoke;
			this.tabContainer1.Name = "tabContainer1";
			this.tabContainer1.SelectedIndex = 0;
			this.tabContainer1.Size = new System.Drawing.Size(1009, 592);
			this.tabContainer1.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
			this.tabContainer1.TabIndex = 12;
			this.tabContainer1.TabStop = false;
			this.tabContainer1.TitleColor = System.Drawing.Color.Gainsboro;
			this.tabContainer1.TitleFont = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.tabContainer1.TitleForceColor = System.Drawing.Color.Black;
			this.tabContainer1.TitleHorizontalAlignment = System.Drawing.StringAlignment.Center;
			this.tabContainer1.TitleSelectedColor = System.Drawing.Color.DarkSeaGreen;
			this.tabContainer1.TitleVerticalAlignment = System.Drawing.StringAlignment.Center;
			// 
			// tabPage1
			// 
			this.tabPage1.Controls.Add(this.btnRun1);
			this.tabPage1.Controls.Add(this.btnOpen1);
			this.tabPage1.Controls.Add(this.btnShot1);
			this.tabPage1.Controls.Add(this.cogToolBlockEditV21);
			this.tabPage1.Controls.Add(this.btnSave1);
			this.tabPage1.Location = new System.Drawing.Point(4, 44);
			this.tabPage1.Name = "tabPage1";
			this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage1.Size = new System.Drawing.Size(1001, 544);
			this.tabPage1.TabIndex = 0;
			this.tabPage1.Text = "相机 1";
			this.tabPage1.UseVisualStyleBackColor = true;
			// 
			// btnRun1
			// 
			this.btnRun1.BackColor = System.Drawing.Color.DarkOrange;
			this.btnRun1.FlatAppearance.BorderSize = 0;
			this.btnRun1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRun1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnRun1.Location = new System.Drawing.Point(913, 101);
			this.btnRun1.Name = "btnRun1";
			this.btnRun1.Size = new System.Drawing.Size(80, 40);
			this.btnRun1.TabIndex = 16;
			this.btnRun1.TabStop = false;
			this.btnRun1.Text = "运行...";
			this.btnRun1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRun1.UseVisualStyleBackColor = false;
			this.btnRun1.Click += new System.EventHandler(this.btnRun1_Click);
			// 
			// btnOpen1
			// 
			this.btnOpen1.BackColor = System.Drawing.Color.DarkOrange;
			this.btnOpen1.FlatAppearance.BorderSize = 0;
			this.btnOpen1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpen1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnOpen1.Location = new System.Drawing.Point(913, 55);
			this.btnOpen1.Name = "btnOpen1";
			this.btnOpen1.Size = new System.Drawing.Size(80, 40);
			this.btnOpen1.TabIndex = 15;
			this.btnOpen1.TabStop = false;
			this.btnOpen1.Text = "打开...";
			this.btnOpen1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOpen1.UseVisualStyleBackColor = false;
			this.btnOpen1.Click += new System.EventHandler(this.btnOpen1_Click);
			// 
			// btnShot1
			// 
			this.btnShot1.BackColor = System.Drawing.Color.DarkOrange;
			this.btnShot1.FlatAppearance.BorderSize = 0;
			this.btnShot1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShot1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnShot1.Location = new System.Drawing.Point(913, 5);
			this.btnShot1.Name = "btnShot1";
			this.btnShot1.Size = new System.Drawing.Size(80, 40);
			this.btnShot1.TabIndex = 14;
			this.btnShot1.TabStop = false;
			this.btnShot1.Text = "拍照";
			this.btnShot1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnShot1.UseVisualStyleBackColor = false;
			this.btnShot1.Click += new System.EventHandler(this.btnShot1_Click);
			// 
			// cogToolBlockEditV21
			// 
			this.cogToolBlockEditV21.AllowDrop = true;
			this.cogToolBlockEditV21.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cogToolBlockEditV21.ContextMenuCustomizer = null;
			this.cogToolBlockEditV21.Location = new System.Drawing.Point(5, 5);
			this.cogToolBlockEditV21.MinimumSize = new System.Drawing.Size(489, 2);
			this.cogToolBlockEditV21.Name = "cogToolBlockEditV21";
			this.cogToolBlockEditV21.ShowNodeToolTips = true;
			this.cogToolBlockEditV21.Size = new System.Drawing.Size(902, 531);
			this.cogToolBlockEditV21.SuspendElectricRuns = false;
			this.cogToolBlockEditV21.TabIndex = 11;
			// 
			// btnSave1
			// 
			this.btnSave1.BackColor = System.Drawing.Color.DarkOrange;
			this.btnSave1.FlatAppearance.BorderSize = 0;
			this.btnSave1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnSave1.Location = new System.Drawing.Point(913, 350);
			this.btnSave1.Name = "btnSave1";
			this.btnSave1.Size = new System.Drawing.Size(80, 40);
			this.btnSave1.TabIndex = 13;
			this.btnSave1.TabStop = false;
			this.btnSave1.Text = "保存";
			this.btnSave1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave1.UseVisualStyleBackColor = false;
			this.btnSave1.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// tabPage2
			// 
			this.tabPage2.Controls.Add(this.btnRun2);
			this.tabPage2.Controls.Add(this.btnOpen2);
			this.tabPage2.Controls.Add(this.btnShot2);
			this.tabPage2.Controls.Add(this.btnSave2);
			this.tabPage2.Controls.Add(this.cogToolBlockEditV22);
			this.tabPage2.Location = new System.Drawing.Point(4, 44);
			this.tabPage2.Name = "tabPage2";
			this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage2.Size = new System.Drawing.Size(1001, 544);
			this.tabPage2.TabIndex = 1;
			this.tabPage2.Text = "相机 2";
			this.tabPage2.UseVisualStyleBackColor = true;
			// 
			// btnRun2
			// 
			this.btnRun2.BackColor = System.Drawing.Color.DarkOrange;
			this.btnRun2.FlatAppearance.BorderSize = 0;
			this.btnRun2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRun2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnRun2.Location = new System.Drawing.Point(913, 101);
			this.btnRun2.Name = "btnRun2";
			this.btnRun2.Size = new System.Drawing.Size(80, 40);
			this.btnRun2.TabIndex = 19;
			this.btnRun2.TabStop = false;
			this.btnRun2.Text = "运行...";
			this.btnRun2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRun2.UseVisualStyleBackColor = false;
			this.btnRun2.Click += new System.EventHandler(this.btnRun2_Click);
			// 
			// btnOpen2
			// 
			this.btnOpen2.BackColor = System.Drawing.Color.DarkOrange;
			this.btnOpen2.FlatAppearance.BorderSize = 0;
			this.btnOpen2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpen2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnOpen2.Location = new System.Drawing.Point(913, 55);
			this.btnOpen2.Name = "btnOpen2";
			this.btnOpen2.Size = new System.Drawing.Size(80, 40);
			this.btnOpen2.TabIndex = 18;
			this.btnOpen2.TabStop = false;
			this.btnOpen2.Text = "打开...";
			this.btnOpen2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOpen2.UseVisualStyleBackColor = false;
			this.btnOpen2.Click += new System.EventHandler(this.btnOpen2_Click);
			// 
			// btnShot2
			// 
			this.btnShot2.BackColor = System.Drawing.Color.DarkOrange;
			this.btnShot2.FlatAppearance.BorderSize = 0;
			this.btnShot2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShot2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnShot2.Location = new System.Drawing.Point(913, 5);
			this.btnShot2.Name = "btnShot2";
			this.btnShot2.Size = new System.Drawing.Size(80, 40);
			this.btnShot2.TabIndex = 17;
			this.btnShot2.TabStop = false;
			this.btnShot2.Text = "拍照";
			this.btnShot2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnShot2.UseVisualStyleBackColor = false;
			this.btnShot2.Click += new System.EventHandler(this.btnShot2_Click);
			// 
			// btnSave2
			// 
			this.btnSave2.BackColor = System.Drawing.Color.DarkOrange;
			this.btnSave2.FlatAppearance.BorderSize = 0;
			this.btnSave2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnSave2.Location = new System.Drawing.Point(913, 350);
			this.btnSave2.Name = "btnSave2";
			this.btnSave2.Size = new System.Drawing.Size(80, 40);
			this.btnSave2.TabIndex = 16;
			this.btnSave2.TabStop = false;
			this.btnSave2.Text = "保存";
			this.btnSave2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave2.UseVisualStyleBackColor = false;
			this.btnSave2.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// cogToolBlockEditV22
			// 
			this.cogToolBlockEditV22.AllowDrop = true;
			this.cogToolBlockEditV22.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cogToolBlockEditV22.ContextMenuCustomizer = null;
			this.cogToolBlockEditV22.Location = new System.Drawing.Point(5, 5);
			this.cogToolBlockEditV22.MinimumSize = new System.Drawing.Size(489, 2);
			this.cogToolBlockEditV22.Name = "cogToolBlockEditV22";
			this.cogToolBlockEditV22.ShowNodeToolTips = true;
			this.cogToolBlockEditV22.Size = new System.Drawing.Size(902, 531);
			this.cogToolBlockEditV22.SuspendElectricRuns = false;
			this.cogToolBlockEditV22.TabIndex = 12;
			// 
			// tabPage3
			// 
			this.tabPage3.Controls.Add(this.btnRun3);
			this.tabPage3.Controls.Add(this.btnOpen3);
			this.tabPage3.Controls.Add(this.btnShot3);
			this.tabPage3.Controls.Add(this.btnSave3);
			this.tabPage3.Controls.Add(this.cogToolBlockEditV23);
			this.tabPage3.Location = new System.Drawing.Point(4, 44);
			this.tabPage3.Name = "tabPage3";
			this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
			this.tabPage3.Size = new System.Drawing.Size(1001, 544);
			this.tabPage3.TabIndex = 2;
			this.tabPage3.Text = "相机 3";
			this.tabPage3.UseVisualStyleBackColor = true;
			// 
			// btnOpen3
			// 
			this.btnOpen3.BackColor = System.Drawing.Color.DarkOrange;
			this.btnOpen3.FlatAppearance.BorderSize = 0;
			this.btnOpen3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpen3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnOpen3.Location = new System.Drawing.Point(913, 55);
			this.btnOpen3.Name = "btnOpen3";
			this.btnOpen3.Size = new System.Drawing.Size(80, 40);
			this.btnOpen3.TabIndex = 18;
			this.btnOpen3.TabStop = false;
			this.btnOpen3.Text = "打开...";
			this.btnOpen3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnOpen3.UseVisualStyleBackColor = false;
			this.btnOpen3.Click += new System.EventHandler(this.btnOpen3_Click);
			// 
			// btnShot3
			// 
			this.btnShot3.BackColor = System.Drawing.Color.DarkOrange;
			this.btnShot3.FlatAppearance.BorderSize = 0;
			this.btnShot3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnShot3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnShot3.Location = new System.Drawing.Point(913, 5);
			this.btnShot3.Name = "btnShot3";
			this.btnShot3.Size = new System.Drawing.Size(80, 40);
			this.btnShot3.TabIndex = 17;
			this.btnShot3.TabStop = false;
			this.btnShot3.Text = "拍照";
			this.btnShot3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnShot3.UseVisualStyleBackColor = false;
			this.btnShot3.Click += new System.EventHandler(this.btnShot3_Click);
			// 
			// btnSave3
			// 
			this.btnSave3.BackColor = System.Drawing.Color.DarkOrange;
			this.btnSave3.FlatAppearance.BorderSize = 0;
			this.btnSave3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnSave3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnSave3.Location = new System.Drawing.Point(913, 350);
			this.btnSave3.Name = "btnSave3";
			this.btnSave3.Size = new System.Drawing.Size(80, 40);
			this.btnSave3.TabIndex = 16;
			this.btnSave3.TabStop = false;
			this.btnSave3.Text = "保存";
			this.btnSave3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnSave3.UseVisualStyleBackColor = false;
			this.btnSave3.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// cogToolBlockEditV23
			// 
			this.cogToolBlockEditV23.AllowDrop = true;
			this.cogToolBlockEditV23.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.cogToolBlockEditV23.ContextMenuCustomizer = null;
			this.cogToolBlockEditV23.Location = new System.Drawing.Point(5, 5);
			this.cogToolBlockEditV23.MinimumSize = new System.Drawing.Size(489, 2);
			this.cogToolBlockEditV23.Name = "cogToolBlockEditV23";
			this.cogToolBlockEditV23.ShowNodeToolTips = true;
			this.cogToolBlockEditV23.Size = new System.Drawing.Size(902, 531);
			this.cogToolBlockEditV23.SuspendElectricRuns = false;
			this.cogToolBlockEditV23.TabIndex = 12;
			// 
			// btnRun3
			// 
			this.btnRun3.BackColor = System.Drawing.Color.DarkOrange;
			this.btnRun3.FlatAppearance.BorderSize = 0;
			this.btnRun3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnRun3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnRun3.Location = new System.Drawing.Point(913, 101);
			this.btnRun3.Name = "btnRun3";
			this.btnRun3.Size = new System.Drawing.Size(80, 40);
			this.btnRun3.TabIndex = 20;
			this.btnRun3.TabStop = false;
			this.btnRun3.Text = "运行...";
			this.btnRun3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnRun3.UseVisualStyleBackColor = false;
			this.btnRun3.Click += new System.EventHandler(this.btnRun3_Click);
			// 
			// FrmVision
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1009, 592);
			this.Controls.Add(this.tabContainer1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmVision";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "视觉程序";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmVision_FormClosing);
			this.Load += new System.EventHandler(this.FrmJobManager_Load);
			this.tabContainer1.ResumeLayout(false);
			this.tabPage1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEditV21)).EndInit();
			this.tabPage2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEditV22)).EndInit();
			this.tabPage3.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.cogToolBlockEditV23)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Cognex.VisionPro.ToolBlock.CogToolBlockEditV2 cogToolBlockEditV21;
		private Utilities.TabContainer tabContainer1;
		private System.Windows.Forms.TabPage tabPage1;
		private System.Windows.Forms.TabPage tabPage2;
		private Cognex.VisionPro.ToolBlock.CogToolBlockEditV2 cogToolBlockEditV22;
		private System.Windows.Forms.TabPage tabPage3;
		private Cognex.VisionPro.ToolBlock.CogToolBlockEditV2 cogToolBlockEditV23;
		internal System.Windows.Forms.Button btnShot1;
		internal System.Windows.Forms.Button btnSave1;
		internal System.Windows.Forms.Button btnOpen1;
		private System.Windows.Forms.OpenFileDialog openFileDialog1;
		internal System.Windows.Forms.Button btnOpen2;
		internal System.Windows.Forms.Button btnShot2;
		internal System.Windows.Forms.Button btnSave2;
		internal System.Windows.Forms.Button btnOpen3;
		internal System.Windows.Forms.Button btnShot3;
		internal System.Windows.Forms.Button btnSave3;
		internal System.Windows.Forms.Button btnRun1;
		internal System.Windows.Forms.Button btnRun2;
		internal System.Windows.Forms.Button btnRun3;
	}
}