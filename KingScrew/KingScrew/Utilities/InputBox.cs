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
	public partial class InputBox : Form
	{
		public InputBox()
		{
			InitializeComponent();
		}
		public static string Show(string caption, string defaultResponse = "-1")
		{
			var inputBox = new InputBox();
			inputBox.Text = caption;
			inputBox.lbTitle.Text = caption;
			return inputBox.ShowDialog() == DialogResult.OK ? inputBox.txt.Text : defaultResponse;
			
		}

		void btnOK_Click(object sender, EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.OK;
		}

		void btnCancel_Click(object sender, EventArgs e)
		{
			DialogResult = System.Windows.Forms.DialogResult.Cancel;
		}

		void InputBox_Load(object sender, EventArgs e)
		{
			txt.Focus();
			txt.SelectAll();
		}
	}
}
