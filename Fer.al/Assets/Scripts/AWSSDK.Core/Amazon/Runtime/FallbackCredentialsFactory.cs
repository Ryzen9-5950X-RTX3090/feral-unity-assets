using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime
{
	public static class FallbackCredentialsFactory
	{
		public delegate AWSCredentials CredentialsGenerator();

		private static AWSCredentials cachedCredentials;

		public static List<CredentialsGenerator> CredentialsGenerators
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

		static FallbackCredentialsFactory()
		{
		}

		public static void Reset()
		{
		}

		public static void Reset(IWebProxy proxy)
		{
		}

		public static AWSCredentials GetCredentials()
		{
			return null;
		}

		public static AWSCredentials GetCredentials(bool fallbackToAnonymous)
		{
			return null;
		}
	}
}
