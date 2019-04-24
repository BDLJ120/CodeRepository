namespace KingScrew
{
    partial class FrmLog
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
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.combLogType = new System.Windows.Forms.ComboBox();
			this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnClose = new System.Windows.Forms.Button();
			this.btnOpenDir = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnFliter = new System.Windows.Forms.Button();
			this.cbKey = new System.Windows.Forms.CheckBox();
			this.cbType = new System.Windows.Forms.CheckBox();
			this.txtKeyword = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// richTextBox1
			// 
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.Location = new System.Drawing.Point(0, 0);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.ReadOnly = true;
			this.richTextBox1.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.ForcedVertical;
			this.richTextBox1.Size = new System.Drawing.Size(784, 590);
			this.richTextBox1.TabIndex = 2;
			this.richTextBox1.Text = "";
			// 
			// combLogType
			// 
			this.combLogType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.combLogType.FormattingEnabled = true;
			this.combLogType.Items.AddRange(new object[] {
            "- ERROR -",
            "-  WARN -",
            "-  INFO -"});
			this.combLogType.Location = new System.Drawing.Point(98, 25);
			this.combLogType.Name = "combLogType";
			this.combLogType.Size = new System.Drawing.Size(95, 28);
			this.combLogType.TabIndex = 15;
			// 
			// dateTimePicker1
			// 
			this.dateTimePicker1.CustomFormat = "yyyy年MM月dd日";
			this.dateTimePicker1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
			this.dateTimePicker1.Location = new System.Drawing.Point(67, 15);
			this.dateTimePicker1.Name = "dateTimePicker1";
			this.dateTimePicker1.Size = new System.Drawing.Size(138, 26);
			this.dateTimePicker1.TabIndex = 14;
			this.dateTimePicker1.Value = new System.DateTime(2018, 12, 7, 13, 53, 43, 0);
			this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btnClose);
			this.panel1.Controls.Add(this.btnOpenDir);
			this.panel1.Controls.Add(this.groupBox1);
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.dateTimePicker1);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
			this.panel1.Location = new System.Drawing.Point(784, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(223, 590);
			this.panel1.TabIndex = 18;
			// 
			// btnClose
			// 
			this.btnClose.BackColor = System.Drawing.Color.DarkOrange;
			this.btnClose.FlatAppearance.BorderSize = 0;
			this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnClose.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnClose.Location = new System.Drawing.Point(125, 327);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(80, 40);
			this.btnClose.TabIndex = 26;
			this.btnClose.Text = "关闭";
			this.btnClose.UseVisualStyleBackColor = false;
			this.btnClose.Visible = false;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// btnOpenDir
			// 
			this.btnOpenDir.BackColor = System.Drawing.Color.DarkOrange;
			this.btnOpenDir.FlatAppearance.BorderSize = 0;
			this.btnOpenDir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnOpenDir.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnOpenDir.Location = new System.Drawing.Point(125, 281);
			this.btnOpenDir.Name = "btnOpenDir";
			this.btnOpenDir.Size = new System.Drawing.Size(80, 40);
			this.btnOpenDir.TabIndex = 25;
			this.btnOpenDir.Text = "打开目录";
			this.btnOpenDir.UseVisualStyleBackColor = false;
			this.btnOpenDir.Click += new System.EventHandler(this.btnOpenDir_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnFliter);
			this.groupBox1.Controls.Add(this.cbKey);
			this.groupBox1.Controls.Add(this.cbType);
			this.groupBox1.Controls.Add(this.combLogType);
			this.groupBox1.Controls.Add(this.txtKeyword);
			this.groupBox1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.groupBox1.Location = new System.Drawing.Point(12, 54);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(199, 203);
			this.groupBox1.TabIndex = 22;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "筛选";
			// 
			// btnFliter
			// 
			this.btnFliter.BackColor = System.Drawing.Color.DarkOrange;
			this.btnFliter.FlatAppearance.BorderSize = 0;
			this.btnFliter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnFliter.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnFliter.Location = new System.Drawing.Point(113, 148);
			this.btnFliter.Name = "btnFliter";
			this.btnFliter.Size = new System.Drawing.Size(80, 40);
			this.btnFliter.TabIndex = 24;
			this.btnFliter.Text = "筛选";
			this.btnFliter.UseVisualStyleBackColor = false;
			this.btnFliter.Click += new System.EventHandler(this.btnFliter_Click);
			// 
			// cbKey
			// 
			this.cbKey.Location = new System.Drawing.Point(8, 72);
			this.cbKey.Name = "cbKey";
			this.cbKey.Size = new System.Drawing.Size(84, 26);
			this.cbKey.TabIndex = 23;
			this.cbKey.Text = "关键字：";
			this.cbKey.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbKey.UseVisualStyleBackColor = true;
			// 
			// cbType
			// 
			this.cbType.Location = new System.Drawing.Point(8, 25);
			this.cbType.Name = "cbType";
			this.cbType.Size = new System.Drawing.Size(84, 28);
			this.cbType.TabIndex = 22;
			this.cbType.Text = "类别：";
			this.cbType.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbType.UseVisualStyleBackColor = true;
			// 
			// txtKeyword
			// 
			this.txtKeyword.Location = new System.Drawing.Point(8, 104);
			this.txtKeyword.Name = "txtKeyword";
			this.txtKeyword.Size = new System.Drawing.Size(185, 26);
			this.txtKeyword.TabIndex = 21;
			// 
			// label1
			// 
			this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.label1.Location = new System.Drawing.Point(6, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(55, 26);
			this.label1.TabIndex = 18;
			this.label1.Text = "日期：";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// FrmLog
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1007, 590);
			this.ControlBox = false;
			this.Controls.Add(this.richTextBox1);
			this.Controls.Add(this.panel1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "FrmLog";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Load += new System.EventHandler(this.FrmLog_Load);
			this.panel1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ComboBox combLogType;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnFliter;
        private System.Windows.Forms.CheckBox cbKey;
		private System.Windows.Forms.CheckBox cbType;
		private System.Windows.Forms.Button btnOpenDir;
		private System.Windows.Forms.Button btnClose;
    }
}