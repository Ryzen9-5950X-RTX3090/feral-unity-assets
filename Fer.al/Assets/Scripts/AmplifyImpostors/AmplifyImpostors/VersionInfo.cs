using System;

namespace AmplifyImpostors
{
	[Serializable]
	public class VersionInfo
	{
		public const byte Major = 0;

		public const byte Minor = 9;

		public const byte Release = 7;

		public static byte Revision;

		public static int FullNumber
		{
			get
			{
				return default(int);
			}
		}

		public static string FullLabel
		{
			get
			{
				return null;
			}
		}

		public static string StaticToString()
		{
			return null;
		}
	}
}
