using System;

namespace ThirdParty.iOS4Unity
{
	public class NSBundle : NSObject
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public string BundleIdentifier
		{
			get
			{
				return null;
			}
		}

		public string BundlePath
		{
			get
			{
				return null;
			}
		}

		public static NSBundle MainBundle
		{
			get
			{
				return null;
			}
		}

		public string ResourcePath
		{
			get
			{
				return null;
			}
		}

		public NSDictionary InfoDictionary
		{
			get
			{
				return null;
			}
		}

		static NSBundle()
		{
		}

		internal NSBundle(IntPtr handle)
		{
		}

		public static NSBundle FromIdentifier(string str)
		{
			return null;
		}

		public static NSBundle FromPath(string path)
		{
			return null;
		}

		public string LocalizedString(string key, string value = "", string table = "")
		{
			return null;
		}
	}
}
