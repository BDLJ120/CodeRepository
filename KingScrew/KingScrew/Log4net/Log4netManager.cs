using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace KingScrew
{
	public class Log4netManager
	{
		/// <summary>
		/// 日志目录，需要与 Log4net.config 文件配置相同
		/// </summary>
		private static string logDir = "d:\\KingScrew\\logs\\";
		public static string LogDir
		{
			get { return logDir; }
			set
			{
				logDir = value;

			}
		}

		public static log4net.ILog GetLogger()
		{
			return log4net.LogManager.GetLogger("mLog");
		}
	}
}
