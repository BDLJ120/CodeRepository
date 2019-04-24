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
	public partial class FrmProductManage : Form
	{
		public FrmProductManage()
		{
			InitializeComponent();
		}

		void RefreshData()
		{
			dataGridView1.DataSource = null;
			dataGridView1.DataSource = ProductManager.GetProducts();
			dataGridView1.Columns[0].Width = 50;
			dataGridView1.Columns[1].Width = 120;
		}

		private void FrmProductManage_Load(object sender, EventArgs e)
		{
			RefreshData();
		}

		private void btnOpen_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 0)
			{
				return;
			}
			int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
			if (id == ProductManager.GetCurProduct().Id)
			{
				return;
			}
			string rs = ProductManager.SetProduct(id);
			if (rs == "OK")
			{
				Close();
			}
			else
			{
				MsgBox.Show("加载产品失败：" + rs, ico: MessageBoxIcon.Error);
			}
		}

		private void btnAdd_Click(object sender, EventArgs e)
		{
			FrmProductEdit frm = new FrmProductEdit();
			frm.ShowDialog();
			RefreshData();
		}

		private void btnModify_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 0)
			{
				return;
			}
			int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;
			FrmProductEdit frm = new FrmProductEdit();
			frm.Id = id;
			frm.ShowDialog();
			dataGridView1.InvalidateRow(dataGridView1.SelectedRows[0].Index);
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (dataGridView1.SelectedRows.Count == 0)
			{
				return;
			}
			int id = (int)dataGridView1.SelectedRows[0].Cells[0].Value;

			string msg = string.Format("删除后不可恢复，确定？ \r\n产品：[{0},{1},{2}]", id,
				ProductManager.GetNameById(id), ProductManager.GetNoteById(id));
			if (MsgBox.Show(msg, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == System.Windows.Forms.DialogResult.OK)
			{
				string rs = ProductManager.DeleteProduct(id);
				if (rs == "OK")
				{
					Globals.MLog.Info(string.Format("成功删除产品 [{0},{1}]", id, ProductManager.GetNoteById(id)));
					MsgBox.Show("删除成功！");
				}
				else
				{
					MsgBox.Show(rs, ico: MessageBoxIcon.Error);
				}
				RefreshData();
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}
	}
}
