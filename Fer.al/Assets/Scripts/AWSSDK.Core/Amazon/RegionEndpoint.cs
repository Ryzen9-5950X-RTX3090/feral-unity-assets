using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Amazon.Internal;

namespace Amazon
{
	public class RegionEndpoint
	{
		public class Endpoint
		{
			public string Hostname
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

			public string AuthRegion
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

			public string SignatureVersionOverride
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

			internal Endpoint(string hostname, string authregion, string signatureVersionOverride)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		private static Dictionary<string, RegionEndpoint> _hashBySystemName;

		public static readonly RegionEndpoint USEast1;

		private static readonly RegionEndpoint USEast1Regional;

		public static readonly RegionEndpoint USEast2;

		public static readonly RegionEndpoint USWest1;

		public static readonly RegionEndpoint USWest2;

		public static readonly RegionEndpoint EUNorth1;

		public static readonly RegionEndpoint EUWest1;

		public static readonly RegionEndpoint EUWest2;

		public static readonly RegionEndpoint EUWest3;

		public static readonly RegionEndpoint EUCentral1;

		public static readonly RegionEndpoint EUSouth1;

		public static readonly RegionEndpoint APEast1;

		public static readonly RegionEndpoint APNortheast1;

		public static readonly RegionEndpoint APNortheast2;

		public static readonly RegionEndpoint APNortheast3;

		public static readonly RegionEndpoint APSouth1;

		public static readonly RegionEndpoint APSoutheast1;

		public static readonly RegionEndpoint APSoutheast2;

		public static readonly RegionEndpoint SAEast1;

		public static readonly RegionEndpoint USGovCloudEast1;

		public static readonly RegionEndpoint USGovCloudWest1;

		public static readonly RegionEndpoint CNNorth1;

		public static readonly RegionEndpoint CNNorthWest1;

		public static readonly RegionEndpoint CACentral1;

		public static readonly RegionEndpoint MESouth1;

		public static readonly RegionEndpoint AFSouth1;

		private static Dictionary<RegionEndpoint, RegionEndpoint> _hashRegionEndpointOverride;

		private static IRegionEndpointProvider _regionEndpointProvider;

		public static IEnumerable<RegionEndpoint> EnumerableAllRegions
		{
			get
			{
				return null;
			}
		}

		private static IRegionEndpointProvider RegionEndpointProvider
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

		public string PartitionName
		{
			get
			{
				return null;
			}
		}

		public string PartitionDnsSuffix
		{
			get
			{
				return null;
			}
		}

		private IRegionEndpoint InternedRegionEndpoint
		{
			get
			{
				return null;
			}
		}

		public static RegionEndpoint GetBySystemName(string systemName)
		{
			return null;
		}

		public static RegionEndpoint GetRegionEndpointOverride(RegionEndpoint regionEndpoint)
		{
			return null;
		}

		private static RegionEndpoint GetEndpoint(string systemName, string displayName)
		{
			return null;
		}

		private RegionEndpoint(string systemName, string displayName)
		{
		}

		public Endpoint GetEndpointForService(string serviceName)
		{
			return null;
		}

		public Endpoint GetEndpointForService(string serviceName, bool dualStack)
		{
			return null;
		}

		public override string ToString()
		{
			return null;
		}
	}
}
