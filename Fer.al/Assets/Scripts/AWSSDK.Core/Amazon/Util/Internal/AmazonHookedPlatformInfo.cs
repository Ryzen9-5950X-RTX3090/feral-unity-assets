using System.Runtime.CompilerServices;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Util.Internal
{
	public class AmazonHookedPlatformInfo
	{
		private static Logger _logger;

		private const string IPHONE_OS = "iPhone OS";

		private const string ANDROID_OS = "Android";

		private static AmazonHookedPlatformInfo instance;

		private string device_platform;

		private string device_model;

		private string device_make;

		private string device_platformVersion;

		private string device_locale;

		private string app_version_name;

		private string app_version_code;

		private string app_package_name;

		private string app_title;

		public string Platform
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string Model
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string Make
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string PlatformVersion
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string PersistentDataPath
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string UnityVersion
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public string Locale
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static AmazonHookedPlatformInfo Instance
		{
			get
			{
				return null;
			}
		}

		public string PackageName
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string VersionName
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string VersionCode
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public string Title
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		private AmazonHookedPlatformInfo()
		{
		}

		public void Init()
		{
		}
	}
}
