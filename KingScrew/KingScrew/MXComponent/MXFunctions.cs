using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ACTMULTILib;

namespace KingScrew
{
	public class MXStation
	{
		ActEasyIF ActEasyIF1 = new ActEasyIF();

		int logicStation;
		public int LogicStation
		{
			get { return logicStation; }
		}

		bool isOpen = false;
		public bool IsOpen
		{
			get { return isOpen; }
		}

		public MXStation(int ls)
		{
			logicStation = ls;
		}

		/// <summary>
		/// 写32位的数据到PLC
		/// </summary>
		/// <param name="reg">PLC的D寄存器</param>
		/// <param name="value">要写的数据（十进制）</param>
		/// <returns>0表示正常，非0为异常</returns>
		public int ActWrite32BitValue(string reg, int value)
		{
			byte[] buffByte = BitConverter.GetBytes(value);
			short[] buffValue16Bit = new short[2];
			buffValue16Bit[0] = BitConverter.ToInt16(buffByte, 0);
			buffValue16Bit[1] = BitConverter.ToInt16(buffByte, 2);
			return ActEasyIF1.WriteDeviceBlock2(reg, 2, buffValue16Bit[0]);
		}

		/// <summary>
		/// 从PLC中读取32位的数据
		/// </summary>
		/// <param name="reg">PLC的D寄存器</param>
		/// <returns>返回32位的数据</returns>
		public int ActRead32BitValue(string reg, out int value)
		{
			short[] buffValue16Bit = new short[2];
			int rs = ActEasyIF1.ReadDeviceBlock2(reg, 2, out buffValue16Bit[0]);
			byte[] low = BitConverter.GetBytes(buffValue16Bit[0]);
			byte[] high = BitConverter.GetBytes(buffValue16Bit[1]);
			byte[] buff = new byte[4] { low[0], low[1], high[0], high[1] };
			value = BitConverter.ToInt32(buff, 0);
			return rs;
		}

		/// <summary>
		/// 打开连接，成功返回 0
		/// </summary>
		public int Open()
		{
			int rs = ActEasyIF1.Open();
			if (rs == 0)
			{
				isOpen = true;
			}
			return rs;
		}

		/// <summary>
		/// 打开连接，成功返回 0
		/// </summary>
		public int Close()
		{
			int rs = ActEasyIF1.Close();
			if (rs == 0)
			{
				isOpen = false;
			}
			return rs;
		}
	}
}
