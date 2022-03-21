using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime
{
	public static class FallbackRegionFactory
	{
		private delegate AWSRegion RegionGenerator();

		private static object _lock;

		private static AWSRegion cachedRegion;

		private static List<RegionGenerator> AllGenerators
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

		private static List<RegionGenerator> NonMetadataGenerators
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

		static FallbackRegionFactory()
		{
		}

		public static void Reset()
		{
		}

		public static RegionEndpoint GetRegionEndpoint()
		{
			return null;
		}

		public static RegionEndpoint GetRegionEndpoint(bool includeInstanceMetadata)
		{
			return null;
		}
	}
}
