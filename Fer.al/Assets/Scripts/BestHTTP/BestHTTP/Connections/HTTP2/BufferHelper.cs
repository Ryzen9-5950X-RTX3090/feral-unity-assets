namespace BestHTTP.Connections.HTTP2
{
	public static class BufferHelper
	{
		public static void SetUInt16(byte[] buffer, int offset, ushort value)
		{
		}

		public static void SetUInt24(byte[] buffer, int offset, uint value)
		{
		}

		public static void SetUInt31(byte[] buffer, int offset, uint value)
		{
		}

		public static void SetUInt32(byte[] buffer, int offset, uint value)
		{
		}

		public static void SetLong(byte[] buffer, int offset, long value)
		{
		}

		public static byte SetBit(byte value, byte bitIdx, bool bitValue)
		{
			return default(byte);
		}

		public static byte SetBit(byte value, byte bitIdx, byte bitValue)
		{
			return default(byte);
		}

		public static byte ReadBit(byte value, byte bitIdx)
		{
			return default(byte);
		}

		public static byte ReadValue(byte value, byte fromBit, byte toBit)
		{
			return default(byte);
		}

		public static ushort ReadUInt16(byte[] buffer, int offset)
		{
			return default(ushort);
		}

		public static uint ReadUInt24(byte[] buffer, int offset)
		{
			return default(uint);
		}

		public static uint ReadUInt31(byte[] buffer, int offset)
		{
			return default(uint);
		}

		public static uint ReadUInt32(byte[] buffer, int offset)
		{
			return default(uint);
		}

		public static long ReadLong(byte[] buffer, int offset)
		{
			return default(long);
		}
	}
}
