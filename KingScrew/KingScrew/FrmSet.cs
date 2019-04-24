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
	public partial class FrmSet : Form
	{
		public FrmSet()
		{
			InitializeComponent();
		}

		private void FrmSPC_Load(object sender, EventArgs e)
		{
			dataGridView1.DataSource = ProductManager.GetCurProduct().Configs;
			dataGridView1.Columns[0].ReadOnly = true;
			dataGridView1.Columns[1].ReadOnly = true;
			dataGridView1.Columns[2].DefaultCellStyle.Format = "N3";
			dataGridView1.Columns[3].DefaultCellStyle.Format = "N3";
		}

		private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
		{
			MsgBox.Show("数据不正确！", ico: MessageBoxIcon.Error);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string str = ProductManager.SavePoduct(ProductManager.GetCurProduct());
			if (str == "OK")
			{
				MsgBox.Show("保存成功！");
			}
			else
			{
				MsgBox.Show("保存失败：" + str, ico: MessageBoxIcon.Error);
			}
			
		}
	}
}
