using System;

namespace ICSharpCode.SharpZipLib.Tar
{
	public class TarEntry : ICloneable
	{
		private string file;

		private TarHeader header;

		public string Name
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public long Size
		{
			get
			{
				return default(long);
			}
		}

		public bool IsDirectory
		{
			get
			{
				return default(bool);
			}
		}

		private TarEntry()
		{
		}

		public TarEntry(byte[] headerBuffer)
		{
		}

		public object Clone()
		{
			return null;
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}
	}
}
