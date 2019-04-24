namespace KingScrew
{
	partial class FrmHome
	{
		/// <summary>
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows 窗体设计器生成的代码

		/// <summary>
		/// 设计器支持所需的方法 - 不要
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmHome));
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.panel3 = new System.Windows.Forms.Panel();
			this.btnUPH = new System.Windows.Forms.Button();
			this.btnProductName = new System.Windows.Forms.Button();
			this.btnVisionState = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.cogRecordDisplay1 = new Cognex.VisionPro.CogRecordDisplay();
			this.cogRecordDisplay2 = new Cognex.VisionPro.CogRecordDisplay();
			this.cogRecordDisplay3 = new Cognex.VisionPro.CogRecordDisplay();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.button1 = new System.Windows.Forms.Button();
			this.panel3.SuspendLayout();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay3)).BeginInit();
			this.SuspendLayout();
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.SystemColors.Control;
			this.panel3.Controls.Add(this.btnUPH);
			this.panel3.Controls.Add(this.btnProductName);
			this.panel3.Controls.Add(this.btnVisionState);
			this.panel3.Location = new System.Drawing.Point(0, 0);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(697, 70);
			this.panel3.TabIndex = 1;
			// 
			// btnUPH
			// 
			this.btnUPH.BackColor = System.Drawing.Color.PaleGoldenrod;
			this.btnUPH.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnUPH.FlatAppearance.BorderSize = 0;
			this.btnUPH.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnUPH.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnUPH.Location = new System.Drawing.Point(255, 5);
			this.btnUPH.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.btnUPH.Name = "btnUPH";
			this.btnUPH.Size = new System.Drawing.Size(120, 60);
			this.btnUPH.TabIndex = 23;
			this.btnUPH.TabStop = false;
			this.btnUPH.Text = "UPH";
			this.btnUPH.UseVisualStyleBackColor = false;
			// 
			// btnProductName
			// 
			this.btnProductName.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.btnProductName.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnProductName.FlatAppearance.BorderSize = 0;
			this.btnProductName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnProductName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnProductName.Location = new System.Drawing.Point(130, 5);
			this.btnProductName.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.btnProductName.Name = "btnProductName";
			this.btnProductName.Size = new System.Drawing.Size(120, 60);
			this.btnProductName.TabIndex = 22;
			this.btnProductName.TabStop = false;
			this.btnProductName.Text = "Product Name";
			this.btnProductName.UseVisualStyleBackColor = false;
			this.btnProductName.Click += new System.EventHandler(this.btnProductName_Click);
			// 
			// btnVisionState
			// 
			this.btnVisionState.BackColor = System.Drawing.Color.DarkSeaGreen;
			this.btnVisionState.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.btnVisionState.FlatAppearance.BorderSize = 0;
			this.btnVisionState.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnVisionState.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnVisionState.Location = new System.Drawing.Point(5, 5);
			this.btnVisionState.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.btnVisionState.Name = "btnVisionState";
			this.btnVisionState.Size = new System.Drawing.Size(120, 60);
			this.btnVisionState.TabIndex = 21;
			this.btnVisionState.TabStop = false;
			this.btnVisionState.Text = "Alarm";
			this.btnVisionState.UseVisualStyleBackColor = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
			this.panel1.Controls.Add(this.dataGridView1);
			this.panel1.Location = new System.Drawing.Point(704, 0);
			this.panel1.Margin = new System.Windows.Forms.Padding(0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(300, 583);
			this.panel1.TabIndex = 2;
			// 
			// dataGridView1
			// 
			this.dataGridView1.AllowUserToAddRows = false;
			this.dataGridView1.AllowUserToDeleteRows = false;
			this.dataGridView1.AllowUserToResizeRows = false;
			this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
			this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dataGridView1.Location = new System.Drawing.Point(0, 0);
			this.dataGridView1.MultiSelect = false;
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.ReadOnly = true;
			this.dataGridView1.RowHeadersVisible = false;
			this.dataGridView1.RowTemplate.Height = 23;
			this.dataGridView1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.CellSelect;
			this.dataGridView1.Size = new System.Drawing.Size(300, 583);
			this.dataGridView1.TabIndex = 0;
			// 
			// cogRecordDisplay1
			// 
			this.cogRecordDisplay1.ColorMapLowerClipColor = System.Drawing.Color.Black;
			this.cogRecordDisplay1.ColorMapLowerRoiLimit = 0D;
			this.cogRecordDisplay1.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
			this.cogRecordDisplay1.ColorMapUpperClipColor = System.Drawing.Color.Black;
			this.cogRecordDisplay1.ColorMapUpperRoiLimit = 1D;
			this.cogRecordDisplay1.Location = new System.Drawing.Point(5, 73);
			this.cogRecordDisplay1.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
			this.cogRecordDisplay1.MouseWheelSensitivity = 1D;
			this.cogRecordDisplay1.Name = "cogRecordDisplay1";
			this.cogRecordDisplay1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay1.OcxState")));
			this.cogRecordDisplay1.Size = new System.Drawing.Size(320, 240);
			this.cogRecordDisplay1.TabIndex = 3;
			// 
			// cogRecordDisplay2
			// 
			this.cogRecordDisplay2.ColorMapLowerClipColor = System.Drawing.Color.Black;
			this.cogRecordDisplay2.ColorMapLowerRoiLimit = 0D;
			this.cogRecordDisplay2.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
			this.cogRecordDisplay2.ColorMapUpperClipColor = System.Drawing.Color.Black;
			this.cogRecordDisplay2.ColorMapUpperRoiLimit = 1D;
			this.cogRecordDisplay2.Location = new System.Drawing.Point(331, 73);
			this.cogRecordDisplay2.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
			this.cogRecordDisplay2.MouseWheelSensitivity = 1D;
			this.cogRecordDisplay2.Name = "cogRecordDisplay2";
			this.cogRecordDisplay2.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay2.OcxState")));
			this.cogRecordDisplay2.Size = new System.Drawing.Size(320, 240);
			this.cogRecordDisplay2.TabIndex = 4;
			// 
			// cogRecordDisplay3
			// 
			this.cogRecordDisplay3.ColorMapLowerClipColor = System.Drawing.Color.Black;
			this.cogRecordDisplay3.ColorMapLowerRoiLimit = 0D;
			this.cogRecordDisplay3.ColorMapPredefined = Cognex.VisionPro.Display.CogDisplayColorMapPredefinedConstants.None;
			this.cogRecordDisplay3.ColorMapUpperClipColor = System.Drawing.Color.Black;
			this.cogRecordDisplay3.ColorMapUpperRoiLimit = 1D;
			this.cogRecordDisplay3.Location = new System.Drawing.Point(5, 319);
			this.cogRecordDisplay3.MouseWheelMode = Cognex.VisionPro.Display.CogDisplayMouseWheelModeConstants.Zoom1;
			this.cogRecordDisplay3.MouseWheelSensitivity = 1D;
			this.cogRecordDisplay3.Name = "cogRecordDisplay3";
			this.cogRecordDisplay3.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("cogRecordDisplay3.OcxState")));
			this.cogRecordDisplay3.Size = new System.Drawing.Size(320, 240);
			this.cogRecordDisplay3.TabIndex = 5;
			// 
			// timer1
			// 
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// Column1
			// 
			this.Column1.HeaderText = "相机";
			this.Column1.Name = "Column1";
			this.Column1.ReadOnly = true;
			// 
			// Column2
			// 
			this.Column2.HeaderText = "项目";
			this.Column2.Name = "Column2";
			this.Column2.ReadOnly = true;
			// 
			// Column3
			// 
			dataGridViewCellStyle3.Format = "N3";
			dataGridViewCellStyle3.NullValue = "0";
			this.Column3.DefaultCellStyle = dataGridViewCellStyle3;
			this.Column3.HeaderText = "结果";
			this.Column3.Name = "Column3";
			this.Column3.ReadOnly = true;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(470, 392);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 6;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// FrmHome
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1009, 592);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.cogRecordDisplay3);
			this.Controls.Add(this.cogRecordDisplay2);
			this.Controls.Add(this.cogRecordDisplay1);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.panel3);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "FrmHome";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Form1";
			this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmHome_FormClosing);
			this.Load += new System.EventHandler(this.FrmHome_Load);
			this.panel3.ResumeLayout(false);
			this.panel1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.cogRecordDisplay3)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Button btnProductName;
		private System.Windows.Forms.Button btnVisionState;
		private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnUPH;
		private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay1;
		private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay2;
		private Cognex.VisionPro.CogRecordDisplay cogRecordDisplay3;
		private System.Windows.Forms.DataGridView dataGridView1;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
		private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
		private System.Windows.Forms.Button button1;
    }
}

