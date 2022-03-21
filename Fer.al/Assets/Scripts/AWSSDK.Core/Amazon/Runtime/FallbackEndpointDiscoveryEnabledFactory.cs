using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime
{
	[Obsolete]
	public static class FallbackEndpointDiscoveryEnabledFactory
	{
		private delegate bool ConfigGenerator();

		private static object _lock;

		private static bool? endpointDiscoveryEnabled;

		private static List<ConfigGenerator> EnabledGenerators
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

		static FallbackEndpointDiscoveryEnabledFactory()
		{
		}

		public static void Reset()
		{
		}

		public static bool? GetEnabled()
		{
			return null;
		}
	}
}
