using System;

namespace ThirdParty.iOS4Unity
{
	public class NSTimeZone : NSObject
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public static string[] KnownTimeZoneNames
		{
			get
			{
				return null;
			}
		}

		public static NSDictionary Abbreviations
		{
			get
			{
				return null;
			}
		}

		public NSData Data
		{
			get
			{
				return null;
			}
		}

		public static string DataVersion
		{
			get
			{
				return null;
			}
		}

		public static NSTimeZone DefaultTimeZone
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int GetSecondsFromGMT
		{
			get
			{
				return default(int);
			}
		}

		public static NSTimeZone LocalTimeZone
		{
			get
			{
				return null;
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
		}

		public static NSTimeZone SystemTimeZone
		{
			get
			{
				return null;
			}
		}

		static NSTimeZone()
		{
		}

		public NSTimeZone()
		{
		}

		public NSTimeZone(string name)
		{
		}

		internal NSTimeZone(IntPtr handle)
		{
		}

		public string Abbreviation(DateTime date)
		{
			return null;
		}

		public virtual string Abbreviation()
		{
			return null;
		}

		public static NSTimeZone FromAbbreviation(string abbreviation)
		{
			return null;
		}

		public static NSTimeZone FromName(string name, NSData data)
		{
			return null;
		}

		public static NSTimeZone FromName(string name)
		{
			return null;
		}

		public static void ResetSystemTimeZone()
		{
		}

		public int SecondsFromGMT(DateTime date)
		{
			return default(int);
		}
	}
}
