using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KingScrew.Utilities
{
	partial class TabContainer : TabControl
	{
		private Color mainBackColor = Color.WhiteSmoke;
		public Color MainBackColor
		{
			get { return mainBackColor; }
			set { mainBackColor = value; Refresh(); }
		}

		private Color titleColor = Color.Gainsboro;
		public Color TitleColor
		{
			get { return titleColor; }
			set { titleColor = value; Refresh(); }
		}

		private Color titleSelectedColor = Color.DarkSeaGreen;
		public Color TitleSelectedColor
		{
			get { return titleSelectedColor; }
			set { titleSelectedColor = value; }
		}
		private Font titleFont = new Font("Arial", 12);

		public Font TitleFont
		{
			get { return titleFont; }
			set { titleFont = value; }
		}
		private Color titleForceColor = Color.Black;

		public Color TitleForceColor
		{
			get { return titleForceColor; }
			set { titleForceColor = value; }
		}
		private StringAlignment titleHorizontalAlignment = StringAlignment.Center;

		public StringAlignment TitleHorizontalAlignment
		{
			get { return titleHorizontalAlignment; }
			set { titleHorizontalAlignment = value; }
		}
		private StringAlignment titleVerticalAlignment = StringAlignment.Center;

		public StringAlignment TitleVerticalAlignment
		{
			get { return titleVerticalAlignment; }
			set { titleVerticalAlignment = value; }
		}

		public TabContainer()
		{
			InitializeComponent();
			this.DrawMode = TabDrawMode.OwnerDrawFixed;
			this.DrawItem += new DrawItemEventHandler(TabContainer_DrawItem);
		}


		void TabContainer_DrawItem(object sender, DrawItemEventArgs e)
		{
			//设置文字对齐方式
			StringFormat StringF = new StringFormat();
			StringF.Alignment = TitleHorizontalAlignment;
			StringF.LineAlignment = TitleVerticalAlignment;
			e.Graphics.FillRectangle(new SolidBrush(MainBackColor), this.ClientRectangle);
			for (int i = 0; i < this.TabPages.Count; i++)
			{
				//获取标签头工作区域
				Rectangle Rec = this.GetTabRect(i);
				Rec.Width -= 5;
				//绘制标签头背景颜色
				if (this.SelectedIndex == i)
				{
					e.Graphics.FillRectangle(new SolidBrush(TitleSelectedColor), Rec);
				}
				else
				{
					e.Graphics.FillRectangle(new SolidBrush(TitleColor), Rec);
				}
				if (ImageList != null)
				{
					if (TabPages[i].ImageIndex > 0 && TabPages[i].ImageIndex < ImageList.Images.Count)
					{
						e.Graphics.DrawImage(ImageList.Images[TabPages[i].ImageIndex], Rec);
					}
				}

				//绘制标签头文字
				e.Graphics.DrawString(this.TabPages[i].Text, TitleFont, new SolidBrush(TitleForceColor), Rec, StringF);
			}
		}


	}
}
