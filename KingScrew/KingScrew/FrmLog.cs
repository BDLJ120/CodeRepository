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
    public partial class FrmLog : Form
    {
		public string LogDir;

        public FrmLog()
        {
            InitializeComponent();
        }

        private void FrmLog_Load(object sender, EventArgs e)
        {
			LogDir = Log4netManager.LogDir;
            dateTimePicker1.Value = DateTime.Now;
			dateTimePicker1_ValueChanged(null, null);
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
			string logFile = LogDir + dateTimePicker1.Value.ToString("yyyy-MM-dd") + ".log";
            if (System.IO.File.Exists(logFile))
            {
                richTextBox1.Text = System.IO.File.ReadAllText(logFile, Encoding.UTF8);
                SetTextColor();
            }
            else
            {
                richTextBox1.Text = dateTimePicker1.Value.ToString("yyyy.MM.dd") + "  无信息！";
            }
        }

        private void btnFliter_Click(object sender, EventArgs e)
        {
			string logFile = LogDir + dateTimePicker1.Value.ToString("yyyy-MM-dd") + ".log";
            if (System.IO.File.Exists(logFile))
            {
                richTextBox1.Clear();
                string[] ls = System.IO.File.ReadAllLines(logFile, Encoding.UTF8);
                for (int i = 0; i < ls.Length; i++)
                {
                    bool typeOK = true, keyOk = true;
                    if (cbType.Checked && combLogType.SelectedItem != null)
                    {
                        typeOK = ls[i].Contains(combLogType.SelectedItem.ToString());
                    }
                    if (cbKey.Checked)
                    {
                        keyOk = ls[i].Contains(txtKeyword.Text.Trim());
                    }
                    if (typeOK && keyOk)
                    {
                        richTextBox1.AppendText(ls[i] + "\r\n");
                    }
                }
                SetTextColor();
            }
            else
            {
                richTextBox1.Text = dateTimePicker1.Value.ToString("yyyy.MM.dd") + "  无信息！";
            }
        }

        public void SetTextColor()
        {
            string[] ls = richTextBox1.Lines;
            int start = 0;
            for (int i = 0; i < ls.Length; i++)
            {
                if (ls[i].Length > 18 )
                {
                    richTextBox1.Select(start + 10, 7);
                    Color c = Color.Green;
                    if (richTextBox1.SelectedText.Contains("ERROR"))
                    {
                        c = Color.Red;
                    }
                    else if (richTextBox1.SelectedText.Contains("WARN"))
                    {
                        c = Color.Orange;
                    }
                    richTextBox1.SelectionColor = c;
                }
                start += ls[i].Length + 1;
            }
            richTextBox1.Select(start, 0);
            richTextBox1.ScrollToCaret();
        }

		private void btnOpenDir_Click(object sender, EventArgs e)
		{
			if (System.IO.Directory.Exists(LogDir))
			{
				System.Diagnostics.Process.Start(LogDir);
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Close();
		}

    }
}
