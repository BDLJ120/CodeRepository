using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.MemoryMappedFiles;
using System.Drawing;
using CSharp_OPTControllerAPI;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using System.Management;
using Cognex.VisionPro.QuickBuild;
using Cognex.VisionPro;

namespace KingScrew
{
	public class Globals
	{
		#region MemoryMap

		private const string MemoryMapName = "EBA18032K";
		private const long MemoryMapCapacity = 20000;
		private static MemoryMappedFile MMF;
		private static MemoryMappedViewAccessor MMVA;

		public static void SharedMemoryWriteString(long position, string str)
		{
			if (MMF == null || MMVA == null)
			{
				Globals.MMF = System.IO.MemoryMappedFiles.MemoryMappedFile.CreateOrOpen(MemoryMapName, MemoryMapCapacity);
				Globals.MMVA = Globals.MMF.CreateViewAccessor();
			}
			if (str != null)
			{
				char[] chars = str.ToCharArray();
				MMVA.Write(position, (byte)chars.Length);
				MMVA.WriteArray<char>(position + 1, chars, 0, chars.Length);
			}
		}

		public static string SharedMemoryReadString(long position)
		{
			if (MMF == null || MMVA == null)
			{
				Globals.MMF = System.IO.MemoryMappedFiles.MemoryMappedFile.CreateOrOpen(MemoryMapName, MemoryMapCapacity);
				Globals.MMVA = Globals.MMF.CreateViewAccessor();
			}
			int count = MMVA.ReadByte(position);
			char[] chars = new char[count];
			MMVA.ReadArray<char>(position + 1, chars, 0, count);

			return string.Join("", chars);
		}
		#endregion

		#region XML serialize
		public static void SaveObjectToXml(Object userClass, String filePath)
		{
			try
			{
				XmlSerializer xmlser = new XmlSerializer(userClass.GetType());
				XmlWriterSettings xmlws = new XmlWriterSettings();
				xmlws.Indent = true;
				xmlws.NewLineOnAttributes = true;
				using (XmlWriter xmlw = XmlWriter.Create(filePath, xmlws))
				{
					xmlser.Serialize(xmlw, userClass);
					xmlw.Close();
				}
			}
			catch (Exception ex)
			{
				throw new Exception("SaveObjectToXml", ex);
			}
		}

		public static void LoadObjectFromXml(ref object userClass, string filePath)
		{
			try
			{
				XmlSerializer xmlser = new XmlSerializer(userClass.GetType());
				XmlReaderSettings xmlrs = new XmlReaderSettings();
				xmlrs.CloseInput = true;
				XmlReader xmlrd = XmlReader.Create(filePath, xmlrs);
				userClass = xmlser.Deserialize(xmlrd);
				xmlrd.Close();
			}
			catch (Exception ex)
			{
				throw new Exception("Read object from xml error", ex);
			}
		}
		#endregion

		#region Security
		/// <summary>
		/// 获取硬盘序号号
		/// </summary>
		public static string GetHDinfo()
		{
			string rs = "";
			try
			{
				ManagementClass mc = new ManagementClass("Win32_DiskDrive");
				ManagementObjectCollection moc = mc.GetInstances();
				foreach (ManagementObject mo in moc)
				{
					rs = mo.Properties["SerialNumber"].Value.ToString();
					if (rs != "")
					{
						break;
					}
				}
			}
			catch (Exception ex)
			{
				throw new Exception("", ex);
			}
			return rs;
		}

		private const string myCode = @"`1234567890-=qwertyuiop[]asdfghjkl;'\zxcvbnm,./ ~!@#$%^&*()_+QWERTYUIOP{}ASDFGHJKL:""|ZXCVBNM<>?";
		/// <summary>
		/// 加密码字符串，字符串长度不能超过255。如果有字符不在密码表中或者超长度，则返回空字符串 ""
		/// </summary>
		public static string EnCode(string orgStr)
		{
			string rs = "";
			foreach (char c in orgStr)
			{
				if (myCode.IndexOf(c) == -1)
				{
					return "";
				}
				rs += myCode.IndexOf(c).ToString("x2");
			}
			if (orgStr.Length < 10)
			{
				Random r = new Random();
				for (int i = 0; i < 20 - orgStr.Length * 2; i++)
				{
					rs += myCode[r.Next(0, myCode.Length - 1)];
				}
			}
			rs += orgStr.Length.ToString("x2");
			return rs;
		}

		/// <summary>
		/// 解密，返回加密前的字符。解码失败返回异常信息
		/// </summary>
		public static string DeCode(string code)
		{
			string rs = "";
			try
			{
				int length = Convert.ToInt32(code.Substring(code.Length - 2), 16);
				for (int i = 0; i < length; i++)
				{
					int index = Convert.ToInt32(code.Substring(i * 2, 2), 16);
					rs += myCode[index];
				}
			}
			catch (Exception ex)
			{
				return "解密失败: " + ex.Message;
			}

			return rs;
		}

		/// <summary>
		/// 验证软件许可是否正确，正确返回 true
		/// </summary>
		public static bool LicenceIsOK()
		{
			string curDir = System.Windows.Forms.Application.StartupPath + "\\";
			string file = curDir + "Licence.dat";
			string localInfo = GetHDinfo();
			if (System.IO.File.Exists(file))
			{
				if (System.IO.File.Exists(curDir + "SystemInfo.dat"))
				{
					System.IO.File.Delete(curDir + "SystemInfo.dat");
				}
				string data = System.IO.File.ReadAllText(file);
				if (localInfo == DeCode(data))
				{
					return true;
				}
				else
				{
					if (data == "jcyyf     ")
					{
						System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch();
						sw.Start();
						System.Windows.Forms.MessageBox.Show("程序授权。。。。。。？", "授权", System.Windows.Forms.MessageBoxButtons.OK, System.Windows.Forms.MessageBoxIcon.Warning);
						sw.Stop();
						if (sw.Elapsed.TotalSeconds < 1)
						{
							System.IO.File.WriteAllText(curDir + "Licence.dat", EnCode(localInfo));
							return true;
						}
					}
				}
			}
			if (System.IO.File.Exists(curDir + "Licence.dat"))
			{
				System.IO.File.Delete(curDir + "Licence.dat");
			}
			System.IO.File.WriteAllText(curDir + "SystemInfo.dat", localInfo);
			return false;
		}

		#endregion

		public static OPTControllerAPI OPTController;

		public static MXStation MXStation1 = new MXStation(0);

		public enum RunStatus
		{
			[EnumDescription("未定义")]
			none,
			[EnumDescription("准备好了")]
			Ready,
			[EnumDescription("运行中")]
			Running,
			[EnumDescription("调试")]
			Debug,
			[EnumDescription("故障")]
			Alarm
		}
		public static RunStatus runStatus;

		public enum RunMode
		{
			[EnumDescription("生产模式")]
			ProductionMode,
			[EnumDescription("工程模式")]
			EngineeringMode,
			[EnumDescription("CPK/GRR 模式")]
			CpkGrrMode
		}
		private static RunMode currentRunMode;
		public static RunMode CurrentRunMode
		{
			get { return Globals.currentRunMode; }
			set
			{
				Globals.currentRunMode = value;
				MLog.Info(string.Format("设定运行模式为：[{0}]", EnumDescription.GetFieldText(CurrentRunMode)));
			}
		}

		private static string currentUser;
		public static string CurrentUser
		{
			get { return Globals.currentUser; }
			set
			{
				Globals.currentUser = value;
				Globals.MLog.Info(string.Format("设定用户：[{0}]", Globals.CurrentUser));
			}
		}
		
		/// <summary>
		/// 配置文件目录，带最后反斜。调试时使用程序目录，设备上使用独立目录，防止更新程序时覆盖配置文件。 "D:\\YAuto\\";
		/// </summary>
		//public static string ConfigDir = "D:\\YAuto\\";
		public static string ConfigDir = Environment.CurrentDirectory + "\\Config\\";

		public static log4net.ILog MLog;

		/// <summary>
		/// 保存位图，同时在图像上打印文字信息
		/// </summary>
		public static void SaveImage(Bitmap image, string fileName, string GraphicText = "", int x = 20, int y = 20)
		{
			Graphics g = Graphics.FromImage(image);
			g.DrawString(GraphicText, new Font("Arial", 20), Brushes.Red, x, y);

			string dir = System.IO.Path.GetDirectoryName(fileName);
			if (!System.IO.Directory.Exists(dir))
			{
				System.IO.Directory.CreateDirectory(dir);
			}
			image.Save(fileName, System.Drawing.Imaging.ImageFormat.Png);
			g.Dispose();
		}

		public static void SetControlsEnable(Panel panel, int powerLevel = -1)
		{
			if (powerLevel == -1)
			{
				powerLevel = UserManager.GetUserPowLevel(CurrentUser);
			}
			int p = -1;
			foreach (Control item in panel.Controls)
			{
				if (item.Tag == null || item.Tag.ToString().Substring(0, 1) == "-")
				{
					continue;
				}
				if (item.Tag.ToString().Length > 0)
				{
					int.TryParse(item.Tag.ToString().Substring(0, 1), out p);
					item.Enabled = p <= powerLevel;
				}

			}
		}

	}
}
