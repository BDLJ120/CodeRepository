using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cognex.VisionPro;
using System.IO;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro.ImageFile;

namespace KingScrew
{
	public class Acqs
	{
		private static string AcqFile = Globals.ConfigDir + "Acqs.dat";

		public static CogAcqFifoTool Acq1, Acq2, Acq3;
		public static CogImageFileTool IFTool;

		/// <summary>
		/// 初始化相机，需要处理异常
		/// </summary>
		public static string Init()
		{
			string rs = "";
			try
			{
				CogToolBlock ctb = CogSerializer.LoadObjectFromFile(AcqFile) as CogToolBlock;
				Acq1 = ctb.Tools[0] as CogAcqFifoTool;
				Acq2 = ctb.Tools[1] as CogAcqFifoTool;
				Acq3 = ctb.Tools[2] as CogAcqFifoTool;
				IFTool = new CogImageFileTool();
			}
			catch (Exception ex)
			{
				rs += ex.Message + ",";
			}

			if (Acq1.Operator == null)
			{
				rs += "cam1 未连接,";
			}
			if (Acq2.Operator == null)
			{
				rs += "cam2 未连接,";
			}
			if (Acq3.Operator == null)
			{
				rs += "cam3 未连接";
			}
			if (rs == "")
			{
				return "OK";
			}
			else
			{
				return rs;
			}
		}

		/// <summary>
		/// 程序退出时调用
		/// </summary>
		public static void Close()
		{
			//if (Acq1.Operator != null)
			//{
			//    Acq1.Operator.FrameGrabber.Disconnect(false);
			//}
		}

	}
}
