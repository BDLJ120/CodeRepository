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
	public partial class FrmProductEdit : Form
	{
		private int id = -1;

		public int Id
		{
			get { return id; }
			set
			{
				id = value;
				tbId.Text = id.ToString();
				tbName.Text = ProductManager.GetNameById(id);
				tbNote.Text = ProductManager.GetNoteById(id);
				Text = "修改产品";
				if (value == 0)
				{
					tbName.ReadOnly = true;
					tbNote.ReadOnly = true;
				}
			}
		}

		public FrmProductEdit()
		{
			InitializeComponent();
		}

		private void FrmProductEdit_Load(object sender, EventArgs e)
		{

		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			tbName.Text = tbName.Text.Trim();
			tbNote.Text = tbNote.Text.Trim();
			Product newProduct = new Product(int.Parse(tbId.Text), tbName.Text.Trim(), tbNote.Text.Trim());
			Product oldProduct = null;
			if (Id == -1) //添加产品，生成 Id
			{
				newProduct.Id = ProductManager.GetNextValidId();
			}
			else
			{
				oldProduct = ProductManager.GetProductById(Id);
			}
			string rs = ProductManager.SavePoduct(newProduct);
			if (rs == "OK")
			{
				string msg = "";
				if (Id == -1)
				{
					msg = string.Format("添加产品成功：[{0},{1}]", newProduct.Id, newProduct.Name);
				}
				else
				{
					msg = string.Format("修改产品成功：[{0}] [{1} -> {2}] [{3} -> {4}]", Id,
						oldProduct.Name, newProduct.Name, oldProduct.Note, newProduct.Note);
				}
				MsgBox.Show(msg);
				Globals.MLog.Info(msg);
				Close();
			}
			else
			{
				MsgBox.Show(rs, ico: MessageBoxIcon.Error);
			}
		}
	}
}
