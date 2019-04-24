using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using Cognex.VisionPro;
using Cognex.VisionPro.ToolBlock;
using System.Data;
using System.ComponentModel;

namespace KingScrew
{
	public class ConfigItem
	{
		[DisplayName("相机")]
		public int CamIndex { get; set; }
		[DisplayName("项目")]
		public string Key { get; set; }
		[DisplayName("上限")]
		public double Usl { get; set; }
		[DisplayName("下限")]
		public double Lsl { get; set; }

		public ConfigItem()
		{
			CamIndex = 1;
			Key = "null";
			Usl = 0;
			Lsl = 0;
		}

		public ConfigItem(int index, string key)
		{
			CamIndex = index;
			Key = key;
			Usl = 0;
			Lsl = 0;
		}

	}

	public class Product
	{
		int id;
		[DisplayName("Id")]
		public int Id
		{
			get { return id; }
			set { id = value; }
		}

		string name;
		[DisplayName("名称")]
		public string Name
		{
			get { return name; }
			set { name = value; }
		}

		string note;
		[DisplayName("说明")]
		public string Note
		{
			get { return note; }
			set { note = value; }
		}

		private List<ConfigItem> config;
		public List<ConfigItem> Configs
		{
			get { return config; }
			set { config = value; }
		}

		public Product()
		{
			Id = -1;
			Name = "";
			Note = "";
			Configs = new List<ConfigItem>();
		}

		public Product(int iId, string strName, string strNote)
		{
			Id = iId;
			Name = strName;
			Note = strNote;
			Configs = new List<ConfigItem>();
		}
	}

	public class ProductManager
	{

		private const string ValidNameChars =
			"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789_#:-+=<>[]{}()";

		/// <summary>
		/// TODO: 产品管理目录，带最后的斜杠
		/// </summary>
		private static string Dir = Globals.ConfigDir + "Products\\";

		/// <summary>
		/// 产品索引表文件
		/// </summary>
		private static string DataFile = Dir + "Products.xml";

		//TODO: 初始产品
		private static Product[] OriginalProducts = new Product[1] { 
			new Product( 0,"Demo","程序模板"), 
		};

		private static List<Product> Products;

		private static bool InitOK = false;

		private static void Init()
		{
			if (!Directory.Exists(Dir))
			{
				Directory.CreateDirectory(Dir);
			}
			object obj = new List<Product>();
			if (File.Exists(DataFile))
			{
				Globals.LoadObjectFromXml(ref obj, DataFile);
				Products = obj as List<Product>;
				InitOK = true;
			}
			else
			{
				Products = obj as List<Product>;
				InitOK = true;
				foreach (Product item in OriginalProducts)
				{
					SavePoduct(item);
				}
			}
			if (Products.Count == 0)
			{
				Globals.MLog.Error("产品管理功能初始化失败");
			}
		}

		/// <summary>
		/// 返回下一个可用的 Id
		/// </summary>
		public static int GetNextValidId()
		{
			if (!InitOK)
			{
				Init();
			}
			List<int> ids = new List<int>();
			foreach (Product item in Products)
			{
				ids.Add(item.Id);
			}
			int i = 0;
			while (ids.Contains(i))
			{
				i++;
			}
			return i;
		}

		/// <summary>
		/// 判断产品名称是否合法，合法返回 true
		/// </summary>
		private static bool IsValidName(string name)
		{
			if (name == null || name.Trim().Length == 0)
			{
				return false;
			}

			List<string> names = new List<string>();
			foreach (Product item in Products)
			{
				names.Add(item.Name);
			}
			if (names.Contains(name))
			{
				return false;
			}

			char[] InvalidChars = Path.GetInvalidFileNameChars();
			foreach (char item in name)
			{
				if (InvalidChars.Contains(item))
				{
					return false;
				}
			}

			return true;
		}

		/// <summary>
		/// 获取产品名称对应的 jobFile 路径。只生成字符串，不做任何验证。
		/// </summary>
		private static string GetJobFilePath(string name)
		{
			return Dir + name + ".vision";
		}

		/// <summary>
		/// 获取 id 对应的 jobFile 路径。只生成字符串，不做任何验证。
		/// </summary>
		private static string GetJobFilePath(int id)
		{
			return Dir + GetNameById(id) + ".vision";
		}

		private static string GetConfigFilePath(int id)
		{
			return Dir + GetNameById(id) + ".cfg";
		}

		/// <summary>
		/// 获得 id 对应产品的名称，id 不存在时，返回空字符 ""
		/// </summary>
		public static string GetNameById(int id)
		{
			if (!InitOK)
			{
				Init();
			}
			Product temp = Products.Find(p => p.Id == id);
			return temp == null ? "" : temp.Name;
		}

		public static string GetNoteById(int id)
		{
			if (!InitOK)
			{
				Init();
			}
			Product temp = Products.Find(p => p.Id == id);
			return temp == null ? "" : temp.Note;
		}

		public static int GetIdByName(string name)
		{
			if (!InitOK)
			{
				Init();
			}
			Product temp = Products.Find(p => p.Name == name);
			return temp == null ? -1 : temp.Id;
		}

		private static Product CurProduct;

		public static Product GetProductById(int id)
		{
			return Products.Find(p => p.Id == id);
		}

		public static Product GetCurProduct()
		{
			return CurProduct;
		}

		/// <summary>
		/// 设定当前产品为指定 id，成功返回 "OK"
		/// </summary>
		public static string SetProduct(int id)
		{

			string jobFilePath = GetJobFilePath(id);
			if (!File.Exists(jobFilePath))
			{
				return "job 文件不存在";
			}
			string str = Vision.LoadJob(jobFilePath);
			if (str == "OK")
			{
				CurProduct = GetProductById(id);
				RefreshConfigItems(CurProduct);
				Globals.MLog.Info(string.Format("设定产品[{0}]", GetNameById(id)));
			}
			else
			{
				Globals.MLog.Error(string.Format("设定产品[{0}]时出错：{1}", GetNameById(id), str));
			}

			return str;
		}

		public static void RefreshConfigItems(Product product)
		{
			List<string> outputs = new List<string>();
			foreach (CogToolBlockTerminal item in Vision.Tb1.Outputs)
			{
				outputs.Add(item.Name);
			}
			product.Configs.RemoveAll(cfg => cfg.CamIndex == 1 && !outputs.Contains(cfg.Key));
			foreach (string str in outputs)
			{
				if (product.Configs.Find(cfg => cfg.CamIndex == 1 && cfg.Key == str) == null)
				{
					product.Configs.Add(new ConfigItem(1, str));
				}
			}

			outputs.Clear();
			foreach (CogToolBlockTerminal item in Vision.Tb2.Outputs)
			{
				outputs.Add(item.Name);
			}
			product.Configs.RemoveAll(cfg => cfg.CamIndex == 2 && !outputs.Contains(cfg.Key));
			foreach (string str in outputs)
			{
				if (product.Configs.Find(cfg => cfg.CamIndex == 2 && cfg.Key == str) == null)
				{
					product.Configs.Add(new ConfigItem(2, str));
				}
			}

			outputs.Clear();
			foreach (CogToolBlockTerminal item in Vision.Tb3.Outputs)
			{
				outputs.Add(item.Name);
			}
			product.Configs.RemoveAll(cfg => cfg.CamIndex == 3 && !outputs.Contains(cfg.Key));
			foreach (string str in outputs)
			{
				if (product.Configs.Find(cfg => cfg.CamIndex == 3 && cfg.Key == str) == null)
				{
					product.Configs.Add(new ConfigItem(3, str));
				}
			}

			product.Configs.Sort((item1, item2) =>
			{
				int rs = item1.CamIndex - item2.CamIndex;
				if (rs == 0)
				{
					rs = item1.Key[0] - item2.Key[0];
				}
				return rs;
			});
		}

		public static string SaveVision()
		{
			string f = GetJobFilePath(CurProduct.Name);
			try
			{
				CogSerializer.SaveObjectToFile(Vision.Tb, f);
			}
			catch (Exception ex)
			{
				string str = "保存产品视觉程序出错：" + ex.Message;
				Globals.MLog.Error(str);
				return str;
			}
			RefreshConfigItems(CurProduct);
			Products.RemoveAll(p => p.Id == CurProduct.Id);
			Products.Add(CurProduct);
			Globals.SaveObjectToXml(Products, DataFile);
			return "OK";
		}

		public static List<Product> GetProducts()
		{
			return Products;
		}

		public static string SavePoduct(Product product)
		{
			if (!InitOK)
			{
				Init();
			}

			if (Products.Find(p => p.Id == product.Id) == null)
			{ //不存在，执行新建产品验证
				if (!IsValidName(product.Name))
				{
					return "产品名称无效";
				}

				if (!File.Exists(GetJobFilePath(product.Name)))
				{
					return "视觉程序不存在";
				}
			}
			else
			{ //已经存在，如果修改了名称，验证名称合法性；移除旧项目
				if (Products.Find(p => p.Id == product.Id).Name != product.Name)
				{ //修改了名称，验证名称合法性
					if (!IsValidName(product.Name))
					{
						return "产品名称无效";
					}
					else
					{
						FileInfo fi = new FileInfo(GetJobFilePath(product.Id));
						fi.MoveTo(GetJobFilePath(product.Name));
					}
				}
				Products.RemoveAll(p => p.Id == product.Id);
			}
			Products.Add(product);
			Globals.SaveObjectToXml(Products, DataFile);
			return "OK";
		}

		public static string DeleteProduct(int id)
		{
			if (!InitOK)
			{
				Init();
			}
			if (Products.Find(p => p.Id == id) == null)
			{
				return "删除失败：产品不存在";
			}
			if (CurProduct.Id == id)
			{
				return "删除失败： 当前加载的产品无法删除";
			}
			if (id == 0)
			{
				return "删除失败：0 号产品为模板产品，不能删除";
			}
			try
			{
				File.Delete(GetJobFilePath(id));
			}
			catch (Exception ex)
			{
				return "删除失败：" + ex.Message;
			}
			Products.RemoveAll(p => p.Id == id);
			Globals.SaveObjectToXml(Products, DataFile);
			return "OK";

		}
	}
}
