using System;
using System.Collections.Generic;

namespace Amazon.Runtime.Internal
{
	public static class FallbackInternalConfigurationFactory
	{
		private delegate InternalConfiguration ConfigGenerator();

		private static InternalConfiguration _cachedConfiguration;

		public static bool? EndpointDiscoveryEnabled
		{
			get
			{
				return null;
			}
		}

		public static RequestRetryMode? RetryMode
		{
			get
			{
				return null;
			}
		}

		public static int? MaxAttempts
		{
			get
			{
				return null;
			}
		}

		static FallbackInternalConfigurationFactory()
		{
		}

		public static void Reset()
		{
		}

		private static T? SeekValue<T>(List<ConfigGenerator> generators, Func<InternalConfiguration, T?> getValue) where T : struct
		{
			return null;
		}
	}
}
