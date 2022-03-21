using System.Runtime.CompilerServices;

namespace Amazon.Util
{
	public class CSMConfig
	{
		internal const string DEFAULT_HOST = "127.0.0.1";

		internal const int DEFAULT_PORT = 31000;

		public string CSMHost
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

		public int CSMPort
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public string CSMClientId
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

		public bool? CSMEnabled
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

		internal void Configure(CSMSection section)
		{
		}
	}
}
