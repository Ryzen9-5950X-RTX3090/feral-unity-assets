using System;
using System.Runtime.CompilerServices;

namespace AppsFlyerSDK
{
	public class AppsFlyerRequestEventArgs : EventArgs
	{
		[CompilerGenerated]
		private readonly int <statusCode>k__BackingField;

		[CompilerGenerated]
		private readonly string <errorDescription>k__BackingField;

		public int statusCode
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
		}

		public string errorDescription
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public AppsFlyerRequestEventArgs(int code, string description)
		{
		}
	}
}
