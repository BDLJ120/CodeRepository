using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cognex.VisionPro.ToolBlock;
using Cognex.VisionPro;
using System.Threading;

namespace KingScrew
{
	public class VisionResultAvailableEventArgs
	{
		public ICogRecord LastRunRecord;
		public SortedList<string, string> DataResult;

		public VisionResultAvailableEventArgs(ICogRecord result, SortedList<string, string> dataResult)
		{
			LastRunRecord = result;
			DataResult = dataResult;
		}

		public override string ToString()
		{
			string rs = "";
			rs = "[";
			foreach (KeyValuePair<string, string> item in DataResult)
			{
				if (item.Key[0] != '_')
				{
					rs += string.Format("{0}:{1},", item.Key, item.Value);
				}
			}
			rs = rs.Remove(rs.Length - 1);
			rs += "]";
			return rs;
		}
	}

	public delegate void VisionResultAvailableEventHandler(object sender, VisionResultAvailableEventArgs e);

	public class Vision
	{
		public static CogToolBlock Tb, Tb1, Tb2, Tb3;

		private static bool StopFlag;

		private const int AcqTimeOut = 2000;

		/// <summary>
		/// 将 jobFile 加载, 成功返回 "OK"
		/// </summary>
		/// <param name="jobFile"></param>
		/// <returns></returns>
		public static string LoadJob(string jobFile)
		{
			try
			{
				Vision.Tb = (CogToolBlock)CogSerializer.LoadObjectFromFile(jobFile);
				Vision.Tb1 = Vision.Tb.Tools[0] as CogToolBlock;
				Vision.Tb2 = Vision.Tb.Tools[1] as CogToolBlock;
				Vision.Tb3 = Vision.Tb.Tools[2] as CogToolBlock;
				return "OK";
			}
			catch (Exception ex)
			{
				string str = "LoadJob：" + ex.Message;
				return str;
			}
		}

		/// <summary>
		/// 写入 CogToolBlock 工具的 Inputs，不抛出异常，异常时写入日志。
		/// </summary>
		public static void WriteBlockInput(CogToolBlock ctb, string key, object value)
		{
			if (ctb.Inputs.Contains(key))
			{
				try
				{
					ctb.Inputs[key].Value = value;
				}
				catch (Exception ex)
				{
					Globals.MLog.Error(string.Format("WriteBlockInput: [{0}] {1} ", key, ex.Message));
				}
			}
			else
			{
				Globals.MLog.Error(string.Format("WriteBlockInput: [{0}]不存在", key));
			}
		}

		public static void StartAutoRun()
		{
			StopFlag = false;
			Cam1AcqThread = new Thread(Cam1AutoAcq);
			Cam1ProcessThread = new Thread(Cam1AutoProcess);
			Cam1AcqThread.Start();
			Cam1ProcessThread.Start();

			Cam2AcqThread = new Thread(Cam2AutoAcq);
			Cam2ProcessThread = new Thread(Cam2AutoProcess);
			Cam2AcqThread.Start();
			Cam2ProcessThread.Start();

			Cam3AcqThread = new Thread(Cam3AutoAcq);
			Cam3ProcessThread = new Thread(Cam3AutoProcess);
			Cam3AcqThread.Start();
			Cam3ProcessThread.Start();
		}

		public static void StopAutoRun()
		{
			StopFlag = true;
		}

		public static bool IsAutoRunning()
		{
			if (Cam1ProcessThread == null && Cam2ProcessThread == null && Cam3ProcessThread == null)
			{
				return false;
			}
			else
			{
				if (Cam1ProcessThread.IsAlive || Cam2ProcessThread.IsAlive || Cam3ProcessThread.IsAlive)
				{
					return true;
				}
				else
				{
					return false;
				}
			}
		}

		#region Cam1
		public static event VisionResultAvailableEventHandler Cam1ResultAvailable = null;
		public static Thread Cam1AcqThread, Cam1ProcessThread;
		public static Queue<ICogImage> Cam1ImageQueue = new Queue<ICogImage>(10) { };

		private static void Cam1AutoAcq()
		{
			Acqs.Acq1.Operator.OwnedTriggerParams.TriggerModel = CogAcqTriggerModelConstants.Auto;
			Acqs.Acq1.Operator.Timeout = AcqTimeOut;
			Acqs.Acq1.Operator.TimeoutEnabled = true;
			Cam1ImageQueue.Clear();
			while (!StopFlag)
			{
				Acqs.Acq1.Run();
				if (Acqs.Acq1.RunStatus.Result == CogToolResultConstants.Accept)
				{
					Cam1ImageQueue.Enqueue(Acqs.Acq1.OutputImage);
				}
			}
		}

		private static void Cam1AutoProcess()
		{
			while (Cam1AcqThread.IsAlive || Cam1ImageQueue.Count > 0)
			{
				if (Cam1ImageQueue.Count > 0)
				{
					SortedList<string, string> rs = RunCam1Program(Cam1ImageQueue.Dequeue());
					if (Cam1ResultAvailable != null)
					{
						Cam1ResultAvailable(null, new VisionResultAvailableEventArgs(Tb1.CreateLastRunRecord(), rs));
					}
				}
			}
		}

		public static SortedList<string, string> RunCam1Program(ICogImage iCogImage)
		{
			WriteBlockInput(Tb1, "Image", iCogImage);
			Tb1.Run();
			Tb1.CreateLastRunRecord();

			SortedList<string, string> rs = new SortedList<string, string>() { };
			rs["RunStatus"] = Tb1.RunStatus.Result.ToString();
			if (rs["RunStatus"] != "Accept")
			{ //检测异常
				rs["Result"] = "4";
				rs["ResultString"] = "检测失败";
				return rs;
			}

			//处理结果，生成结果
			rs["Result"] = "1";
			rs["ResultString"] = "OK";
			rs["NGKeys"] = "";
			foreach (CogToolBlockTerminal item in Tb1.Outputs)
			{
				ConfigItem cfg = ProductManager.GetCurProduct().Configs.Find(cfi => cfi.CamIndex == 1 && cfi.Key == item.Name);
				double value = 0;
				double.TryParse(item.Value.ToString(), out value);
				value = Math.Round(value, 3);
				rs.Add(item.Name, value.ToString());
				if (value > cfg.Usl || value < cfg.Lsl)
				{
					rs["Result"] = "2";
					rs["ResultString"] = "NG";
					rs["NGKeys"] += item.Name + ",";
				}
			}
			return rs;
		}

		#endregion

		#region Cam2
		public static event VisionResultAvailableEventHandler Cam2ResultAvailable = null;
		public static Thread Cam2AcqThread, Cam2ProcessThread;
		public static Queue<ICogImage> Cam2ImageQueue = new Queue<ICogImage>(10) { };

		private static void Cam2AutoAcq()
		{
			Acqs.Acq2.Operator.OwnedTriggerParams.TriggerModel = CogAcqTriggerModelConstants.Auto;
			Acqs.Acq2.Operator.Timeout = AcqTimeOut;
			Acqs.Acq2.Operator.TimeoutEnabled = true;
			Cam2ImageQueue.Clear();
			while (!StopFlag)
			{
				Acqs.Acq2.Run();
				if (Acqs.Acq2.RunStatus.Result == CogToolResultConstants.Accept)
				{
					Cam2ImageQueue.Enqueue(Acqs.Acq2.OutputImage);
				}
			}
		}

		private static void Cam2AutoProcess()
		{
			while (Cam2AcqThread.IsAlive || Cam2ImageQueue.Count > 0)
			{
				if (Cam2ImageQueue.Count > 0)
				{
					SortedList<string, string> rs = RunCam2Program(Cam2ImageQueue.Dequeue());
					if (Cam2ResultAvailable != null)
					{
						Cam2ResultAvailable(null, new VisionResultAvailableEventArgs(Tb2.CreateLastRunRecord(), rs));
					}
				}
			}
		}

		public static SortedList<string, string> RunCam2Program(ICogImage iCogImage)
		{
			WriteBlockInput(Tb2, "Image", iCogImage);
			Tb2.Run();
			Tb2.CreateLastRunRecord();

			SortedList<string, string> rs = new SortedList<string, string>() { };
			rs["RunStatus"] = Tb2.RunStatus.Result.ToString();
			if (rs["RunStatus"] != "Accept")
			{ //检测异常
				rs["Result"] = "4";
				rs["ResultString"] = "检测失败";
				return rs;
			}

			//处理结果，生成结果
			rs["Result"] = "1";
			rs["ResultString"] = "OK";
			rs["NGKeys"] = "";
			foreach (CogToolBlockTerminal item in Tb2.Outputs)
			{
				ConfigItem cfg = ProductManager.GetCurProduct().Configs.Find(cfi => cfi.CamIndex == 2 && cfi.Key == item.Name);
				double value = 0;
				double.TryParse(item.Value.ToString(), out value);
				value = Math.Round(value, 3);
				rs.Add(item.Name, value.ToString());
				if (value > cfg.Usl || value < cfg.Lsl)
				{
					rs["Result"] = "2";
					rs["ResultString"] = "NG";
					rs["NGKeys"] += item.Name + ",";
				}
			}
			return rs;
		}

		#endregion

		#region Cam3
		public static event VisionResultAvailableEventHandler Cam3ResultAvailable = null;
		public static Thread Cam3AcqThread, Cam3ProcessThread;
		public static Queue<ICogImage> Cam3ImageQueue = new Queue<ICogImage>(10) { };

		private static void Cam3AutoAcq()
		{
			Acqs.Acq3.Operator.OwnedTriggerParams.TriggerModel = CogAcqTriggerModelConstants.Auto;
			Acqs.Acq3.Operator.Timeout = AcqTimeOut;
			Acqs.Acq3.Operator.TimeoutEnabled = true;
			Cam3ImageQueue.Clear();
			while (!StopFlag)
			{
				Acqs.Acq3.Run();
				if (Acqs.Acq3.RunStatus.Result == CogToolResultConstants.Accept)
				{
					Cam3ImageQueue.Enqueue(Acqs.Acq3.OutputImage);
				}
			}
		}

		private static void Cam3AutoProcess()
		{
			while (Cam3AcqThread.IsAlive || Cam3ImageQueue.Count > 0)
			{
				if (Cam3ImageQueue.Count > 0)
				{
					SortedList<string, string> rs = RunCam3Program(Cam3ImageQueue.Dequeue());
					if (Cam3ResultAvailable != null)
					{
						Cam3ResultAvailable(null, new VisionResultAvailableEventArgs(Tb3.CreateLastRunRecord(), rs));
					}
				}
			}
		}

		public static SortedList<string, string> RunCam3Program(ICogImage iCogImage)
		{
			WriteBlockInput(Tb3, "Image", iCogImage);
			Tb3.Run();
			Tb3.CreateLastRunRecord();

			SortedList<string, string> rs = new SortedList<string, string>() { };
			rs["RunStatus"] = Tb3.RunStatus.Result.ToString();
			if (rs["RunStatus"] != "Accept")
			{ //检测异常
				rs["Result"] = "4";
				rs["ResultString"] = "检测失败";
				return rs;
			}

			//处理结果，生成结果
			rs["Result"] = "1";
			rs["ResultString"] = "OK";
			rs["NGKeys"] = "";
			foreach (CogToolBlockTerminal item in Tb3.Outputs)
			{
				ConfigItem cfg = ProductManager.GetCurProduct().Configs.Find(cfi => cfi.CamIndex == 3 && cfi.Key == item.Name);
				double value = 0;
				double.TryParse(item.Value.ToString(), out value);
				value = Math.Round(value, 3);
				rs.Add(item.Name, value.ToString());
				if (value > cfg.Usl || value < cfg.Lsl)
				{
					rs["Result"] = "2";
					rs["ResultString"] = "NG";
					rs["NGKeys"] += item.Name + ",";
				}
			}
			return rs;
		}

		#endregion


	}
}
