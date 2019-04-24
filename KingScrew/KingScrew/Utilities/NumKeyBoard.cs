using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KingScrew
{
	public partial class NumKeyBoard : UserControl
	{
		public NumKeyBoard()
		{
			InitializeComponent();
		}

		private NumericUpDown mNUD;

		private void NumberKeyboard_Load(Object sender, System.EventArgs e)
		{
			if (!DesignMode)
			{
				foreach (Control c in Panel1.Controls)
				{
					if (c is Button)
					{
						c.Click += new EventHandler(Button_Click);
					}
				}
			}
		}

		private void Button_Click(Object sender, System.EventArgs e)
		{
			var b = sender as Button;
			decimal d = 0;
			string txt = Lb_txt.Text;
			if (b.Tag.ToString() == "OK")
			{
				if (mNUD != null & decimal.TryParse(txt, out d))
				{
					mNUD.Value = decimal.Parse(txt);
				}
				txt = "";
				this.Visible = false;
			}
			else if (b.Tag.ToString() == "CLEAR")
			{
				txt = "";
			}
			else if (b.Tag.ToString() == "CLOSE")
			{
				txt = "";
				this.Visible = false;
			}
			else if (b.Text == "+/-")
			{
				if (txt.Length > 0 & txt[0] == '-')
				{
					txt = txt.Remove(0, 1);
				}
				else
				{
					txt = txt.Insert(0, "-");
				}
			}
			else if (b.Tag.ToString() == "DELETE")
			{
				if (txt.Length > 0)
				{
					txt = txt.Remove(txt.Length - 1, 1);
				}
			}
			else
			{
				txt += b.Tag.ToString();
			}
			if (this.Visible)
			{
				Lb_txt.Text = txt;
                if (decimal.TryParse(txt, out d) & d >= decimal.Parse(Lb_min.Text) & d <= decimal.Parse(Lb_max.Text))
				{
					Lb_txt.ForeColor = Color.Green;
					Bt_ok.Enabled = true;
				}
				else
				{
					Lb_txt.ForeColor = Color.Red;
					Bt_ok.Enabled = false;
				}
			}

		}

		private void NumberKeyboard_Resize(Object sender, System.EventArgs e)
		{
			this.Size = new Size(200, 285);
		}

		private void Display(NumericUpDown nud)
		{
			Lb_txt.Text = "";
			Lb_txt.ForeColor = Color.Black;
			mNUD = nud;
			Lb_max.Text = nud.Maximum.ToString();
			Lb_min.Text = nud.Minimum.ToString();

			//确定显示位置
			Control myParent = this.Parent;
			Control nudParent = nud.Parent;
			Point loc = new Point(nud.Location.X, nud.Location.Y + nud.Height);
			while (myParent != nudParent)
			{
				loc.X += nudParent.Location.X;
				loc.Y += nudParent.Location.Y;
				nudParent = nudParent.Parent;
			}
			if (loc.X + this.Width > Parent.Width)
			{
				loc.X = myParent.Width - this.Width;
			}
			if (loc.Y + this.Height > Parent.Height - 20)  //减去20是为了去掉状态栏的影响
			{
				loc.Y = loc.Y - this.Height - nud.Height;
			}
			this.Location = loc;

			//显示
			this.BringToFront();
			this.Visible = true;
		}

		public void Attach(NumericUpDown nud)
		{
			nud.Click += new EventHandler(NumericUpDown_Click);
		}

		private void NumericUpDown_Click(Object sender, System.EventArgs e)
		{
			Display(sender as NumericUpDown);
		}
	}
}
