using System;

namespace ICSharpCode.SharpZipLib.Zip
{
	public class ZipEntry : ICloneable
	{
		[Flags]
		private enum Known : byte
		{
			None = 0,
			Size = 1,
			CompressedSize = 2,
			Crc = 4,
			Time = 8,
			ExternalAttributes = 0x10
		}

		private Known known;

		private int externalFileAttributes;

		private ushort versionMadeBy;

		private string name;

		private ulong size;

		private ulong compressedSize;

		private ushort versionToExtract;

		private uint crc;

		private uint dosTime;

		private CompressionMethod method;

		private byte[] extra;

		private string comment;

		private int flags;

		private long zipFileIndex;

		private long offset;

		private bool forceZip64_;

		private byte cryptoCheckValue_;

		private int _aesVer;

		private int _aesEncryptionStrength;

		public bool IsCrypted
		{
			get
			{
				return default(bool);
			}
		}

		internal byte CryptoCheckValue
		{
			get
			{
				return default(byte);
			}
			set
			{
			}
		}

		public int Flags
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public long ZipFileIndex
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		public long Offset
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		public int ExternalFileAttributes
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int HostSystem
		{
			get
			{
				return default(int);
			}
		}

		public int Version
		{
			get
			{
				return default(int);
			}
		}

		public bool LocalHeaderRequiresZip64
		{
			get
			{
				return default(bool);
			}
		}

		public bool CentralHeaderRequiresZip64
		{
			get
			{
				return default(bool);
			}
		}

		public long DosTime
		{
			set
			{
			}
		}

		public DateTime DateTime
		{
			set
			{
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
		}

		public long Size
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		public long CompressedSize
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		public long Crc
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		public CompressionMethod CompressionMethod
		{
			get
			{
				return default(CompressionMethod);
			}
		}

		public byte[] ExtraData
		{
			set
			{
			}
		}

		public int AESKeySize
		{
			get
			{
				return default(int);
			}
		}

		internal int AESSaltLen
		{
			get
			{
				return default(int);
			}
		}

		public string Comment
		{
			set
			{
			}
		}

		public bool IsDirectory
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsFile
		{
			get
			{
				return default(bool);
			}
		}

		internal ZipEntry(string name, int versionRequiredToExtract, int madeByInfo, CompressionMethod method)
		{
		}

		private bool HasDosAttributes(int attributes)
		{
			return default(bool);
		}

		internal void ProcessExtraData(bool localHeader)
		{
		}

		private void ProcessAESExtraData(ZipExtraData extraData)
		{
		}

		public bool IsCompressionMethodSupported()
		{
			return default(bool);
		}

		public object Clone()
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}

		public static bool IsCompressionMethodSupported(CompressionMethod method)
		{
			return default(bool);
		}
	}
}
