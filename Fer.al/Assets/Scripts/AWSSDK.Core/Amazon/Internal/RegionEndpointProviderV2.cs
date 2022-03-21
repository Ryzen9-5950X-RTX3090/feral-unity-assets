using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using ThirdParty.Json.LitJson;

namespace Amazon.Internal
{
	public class RegionEndpointProviderV2 : IRegionEndpointProvider
	{
		public class RegionEndpoint : IRegionEndpoint
		{
			private const string REGIONS_FILE = "Amazon.endpoints.json";

			private const string REGIONS_CUSTOMIZATIONS_FILE = "Amazon.endpoints.customizations.json";

			private const string DEFAULT_RULE = "*/*";

			private static Dictionary<string, JsonData> _documentEndpoints;

			private const int MAX_DOWNLOAD_RETRIES = 3;

			private static bool loaded;

			private static readonly object LOCK_OBJECT;

			private static Dictionary<string, RegionEndpoint> hashBySystemName;

			public static IEnumerable<RegionEndpoint> EnumerableAllRegions
			{
				get
				{
					return null;
				}
			}

			public string SystemName
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

			public string DisplayName
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

			public string RegionName
			{
				get
				{
					return null;
				}
			}

			public Amazon.RegionEndpoint.Endpoint GetEndpointForService(string serviceName, bool dualStack)
			{
				return null;
			}

			private JsonData GetEndpointRule(string serviceName)
			{
				return null;
			}

			private static RegionEndpoint GetEndpoint(string systemName, string displayName)
			{
				return null;
			}

			public static RegionEndpoint GetBySystemName(string systemName)
			{
				return null;
			}

			private static void LoadEndpointDefinitions()
			{
			}

			public static void LoadEndpointDefinitions(string endpointsPath)
			{
			}

			private static void ReadEndpointFile(Stream stream)
			{
			}

			private static void LoadEndpointDefinitionsFromEmbeddedResource()
			{
			}

			public static void UnloadEndpointDefinitions()
			{
			}

			private RegionEndpoint(string systemName, string displayName)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		public static IWebProxy Proxy
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

		public IEnumerable<IRegionEndpoint> AllRegionEndpoints
		{
			get
			{
				return null;
			}
		}

		public IRegionEndpoint GetRegionEndpoint(string regionName)
		{
			return null;
		}
	}
}
