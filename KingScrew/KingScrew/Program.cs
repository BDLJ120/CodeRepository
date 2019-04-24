using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace KingScrew
{
	static class Program
	{
		/// <summary>
		/// 应用程序的主入口点。
		/// </summary>
		[STAThread]
		static void Main()
		{
			System.Diagnostics.Process cur = System.Diagnostics.Process.GetCurrentProcess();
			if (System.Diagnostics.Process.GetProcessesByName(cur.ProcessName).Length > 1)
			{
				MsgBox.Show("程序已经启动！");
				return;
			}
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new FrmFrame());
		}
	}
}
