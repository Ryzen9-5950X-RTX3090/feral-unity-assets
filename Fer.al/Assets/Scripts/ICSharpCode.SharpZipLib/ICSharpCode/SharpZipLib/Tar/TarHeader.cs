using System;
using System.Text;

namespace ICSharpCode.SharpZipLib.Tar
{
	public class TarHeader : ICloneable
	{
		private static readonly DateTime dateTime1970;

		private string name;

		private int mode;

		private int userId;

		private int groupId;

		private long size;

		private DateTime modTime;

		private int checksum;

		private bool isChecksumValid;

		private byte typeFlag;

		private string linkName;

		private string magic;

		private string version;

		private string userName;

		private string groupName;

		private int devMajor;

		private int devMinor;

		internal static string groupNameAsSet;

		internal static int defaultUserId;

		internal static int defaultGroupId;

		internal static string defaultGroupName;

		internal static string defaultUser;

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

		public int UserId
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int GroupId
		{
			get
			{
				return default(int);
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
			set
			{
			}
		}

		public DateTime ModTime
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public int Checksum
		{
			get
			{
				return default(int);
			}
		}

		public bool IsChecksumValid
		{
			get
			{
				return default(bool);
			}
		}

		public byte TypeFlag
		{
			get
			{
				return default(byte);
			}
			set
			{
			}
		}

		public string LinkName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Magic
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Version
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string UserName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string GroupName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int DevMajor
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int DevMinor
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public object Clone()
		{
			return null;
		}

		public void ParseBuffer(byte[] header)
		{
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public static long ParseOctal(byte[] header, int offset, int length)
		{
			return default(long);
		}

		public static StringBuilder ParseName(byte[] header, int offset, int length)
		{
			return null;
		}

		private static int MakeCheckSum(byte[] buffer)
		{
			return default(int);
		}

		private static DateTime GetDateTimeFromCTime(long ticks)
		{
			return default(DateTime);
		}
	}
}
