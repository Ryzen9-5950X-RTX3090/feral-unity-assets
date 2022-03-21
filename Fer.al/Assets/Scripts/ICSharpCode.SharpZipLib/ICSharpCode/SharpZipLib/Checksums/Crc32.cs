namespace ICSharpCode.SharpZipLib.Checksums
{
	public sealed class Crc32
	{
		private static readonly uint[] CrcTable;

		private uint crc;

		public long Value
		{
			get
			{
				return default(long);
			}
		}

		internal static uint ComputeCrc32(uint oldCrc, byte value)
		{
			return default(uint);
		}

		public void Update(int value)
		{
		}

		public void Update(byte[] buffer, int offset, int count)
		{
		}
	}
}
