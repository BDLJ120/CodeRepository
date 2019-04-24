using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace KingScrew
{
	/// <summary>
	/// 给枚举类型添加描述
	/// </summary>
	[AttributeUsage(AttributeTargets.Field | AttributeTargets.Enum)]
	public class EnumDescription : Attribute
	{
		private string enumDisplayText;
		private FieldInfo fieldInfo;

		public EnumDescription(string displayText)
		{
			enumDisplayText = displayText;
		}

		public string EnumDisplayText
		{
			get
			{
				return enumDisplayText;
			}
		}

		public string FieldName
		{
			get
			{
				return fieldInfo.Name;
			}
		}

		public string EnumValue
		{
			get
			{
				return fieldInfo.GetValue(null).ToString();
			}
		}

		private static Hashtable cachedEnum = new Hashtable();

		public static string GetEnumText(Type enumType)
		{
			EnumDescription[] eds = (EnumDescription[])enumType.GetCustomAttributes(typeof(EnumDescription), false);
			if (eds.Length != 1)
			{
				return "";
			}
			else
			{
				return eds[0].enumDisplayText;
			}
		}

		public static EnumDescription[] GetAllFieldTexts(Type enumType)
		{
			EnumDescription[] descriptions;
			if (!cachedEnum.Contains(enumType.FullName))
			{
				FieldInfo[] fields = enumType.GetFields();
				ArrayList al = new ArrayList();
				foreach (FieldInfo fi in fields)
				{
					object[] eds = fi.GetCustomAttributes(typeof(EnumDescription), false);
					if (eds.Length != 1)
					{
						continue;
					}
					(eds[0] as EnumDescription).fieldInfo = fi;
					al.Add(eds[0]);
				}
				cachedEnum.Add(enumType.FullName, al.ToArray(typeof(EnumDescription)));
			}

			descriptions = cachedEnum[enumType.FullName] as EnumDescription[];

			if (descriptions.Length <= 0)
			{
				throw new NotSupportedException("枚举类型[" + enumType.Name + "]未定义属性 EnumValueDescription");
			}
			return descriptions;
		}

		/// <summary>
		/// 获取枚举类型的描述信息
		/// </summary>
		/// <param name="enumValue">枚举变量</param>
		/// <returns>返回枚举类型的描述信息,类型为字符串</returns>
		public static string GetFieldText(object enumValue)
		{
			EnumDescription[] descriptions = GetAllFieldTexts(enumValue.GetType());
			foreach (EnumDescription ed in descriptions)
			{
				if (ed.FieldName == enumValue.ToString())
				{
					return ed.EnumDisplayText;
				}
			}
			return "";
		}
	}
}
