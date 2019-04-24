namespace KingScrew
{
	partial class MsgBox
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MsgBox));
			this.btnNo = new System.Windows.Forms.Button();
			this.btnYes = new System.Windows.Forms.Button();
			this.btnCancel = new System.Windows.Forms.Button();
			this.icos = new System.Windows.Forms.ImageList(this.components);
			this.pic = new System.Windows.Forms.PictureBox();
			this.lbMsg = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
			this.SuspendLayout();
			// 
			// btnNo
			// 
			this.btnNo.BackColor = System.Drawing.Color.DarkOrange;
			this.btnNo.FlatAppearance.BorderSize = 0;
			this.btnNo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnNo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnNo.Location = new System.Drawing.Point(166, 146);
			this.btnNo.Margin = new System.Windows.Forms.Padding(5);
			this.btnNo.Name = "btnNo";
			this.btnNo.Size = new System.Drawing.Size(80, 40);
			this.btnNo.TabIndex = 19;
			this.btnNo.TabStop = false;
			this.btnNo.Text = "否";
			this.btnNo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnNo.UseVisualStyleBackColor = false;
			this.btnNo.Visible = false;
			this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
			// 
			// btnYes
			// 
			this.btnYes.BackColor = System.Drawing.Color.DarkOrange;
			this.btnYes.FlatAppearance.BorderSize = 0;
			this.btnYes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnYes.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnYes.Location = new System.Drawing.Point(76, 146);
			this.btnYes.Margin = new System.Windows.Forms.Padding(5);
			this.btnYes.Name = "btnYes";
			this.btnYes.Size = new System.Drawing.Size(80, 40);
			this.btnYes.TabIndex = 18;
			this.btnYes.TabStop = false;
			this.btnYes.Text = "是";
			this.btnYes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnYes.UseVisualStyleBackColor = false;
			this.btnYes.Visible = false;
			this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
			// 
			// btnCancel
			// 
			this.btnCancel.BackColor = System.Drawing.Color.DarkOrange;
			this.btnCancel.FlatAppearance.BorderSize = 0;
			this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnCancel.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btnCancel.Location = new System.Drawing.Point(256, 146);
			this.btnCancel.Margin = new System.Windows.Forms.Padding(5);
			this.btnCancel.Name = "btnCancel";
			this.btnCancel.Size = new System.Drawing.Size(80, 40);
			this.btnCancel.TabIndex = 21;
			this.btnCancel.TabStop = false;
			this.btnCancel.Text = "取消";
			this.btnCancel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
			this.btnCancel.UseVisualStyleBackColor = false;
			this.btnCancel.Visible = false;
			this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
			// 
			// icos
			// 
			this.icos.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("icos.ImageStream")));
			this.icos.TransparentColor = System.Drawing.Color.Transparent;
			this.icos.Images.SetKeyName(0, "Question");
			this.icos.Images.SetKeyName(1, "Information");
			this.icos.Images.SetKeyName(2, "Error");
			this.icos.Images.SetKeyName(3, "Warning");
			// 
			// pic
			// 
			this.pic.BackColor = System.Drawing.Color.Gainsboro;
			this.pic.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.pic.ErrorImage = null;
			this.pic.ImageLocation = "";
			this.pic.InitialImage = null;
			this.pic.Location = new System.Drawing.Point(11, 14);
			this.pic.Margin = new System.Windows.Forms.Padding(5, 5, 0, 5);
			this.pic.Name = "pic";
			this.pic.Size = new System.Drawing.Size(60, 60);
			this.pic.TabIndex = 22;
			this.pic.TabStop = false;
			// 
			// lbMsg
			// 
			this.lbMsg.BackColor = System.Drawing.Color.Gainsboro;
			this.lbMsg.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.lbMsg.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lbMsg.Location = new System.Drawing.Point(76, 14);
			this.lbMsg.Multiline = true;
			this.lbMsg.Name = "lbMsg";
			this.lbMsg.ReadOnly = true;
			this.lbMsg.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.lbMsg.Size = new System.Drawing.Size(301, 124);
			this.lbMsg.TabIndex = 23;
			this.lbMsg.TabStop = false;
			// 
			// MsgBox
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(389, 200);
			this.ControlBox = false;
			this.Controls.Add(this.lbMsg);
			this.Controls.Add(this.pic);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnNo);
			this.Controls.Add(this.btnYes);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "MsgBox";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Load += new System.EventHandler(this.MsgBox_Load);
			((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		internal System.Windows.Forms.Button btnNo;
		internal System.Windows.Forms.Button btnYes;
		internal System.Windows.Forms.Button btnCancel;
		private System.Windows.Forms.PictureBox pic;
		private System.Windows.Forms.ImageList icos;
		private System.Windows.Forms.TextBox lbMsg;
	}
}