namespace ICSharpCode.SharpZipLib.Checksums
{
	public sealed class Adler32
	{
		private uint checksum;

		public long Value
		{
			get
			{
				return default(long);
			}
		}

		public void Reset()
		{
		}

		public void Update(byte[] buffer, int offset, int count)
		{
		}
	}
}
