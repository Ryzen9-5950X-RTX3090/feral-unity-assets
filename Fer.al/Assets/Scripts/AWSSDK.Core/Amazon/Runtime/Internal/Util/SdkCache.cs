using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal.Util
{
	public static class SdkCache
	{
		internal class CacheKey
		{
			public ImmutableCredentials ImmutableCredentials
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

			public RegionEndpoint RegionEndpoint
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

			public string ServiceUrl
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

			public object CacheType
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

			private CacheKey()
			{
			}

			public static CacheKey Create(AmazonServiceClient client, object cacheType)
			{
				return null;
			}

			public static CacheKey Create(object cacheType)
			{
				return null;
			}

			public override int GetHashCode()
			{
				return default(int);
			}

			public override bool Equals(object obj)
			{
				return default(bool);
			}
		}

		private static object cacheLock;

		private static Cache<CacheKey, ICache> cache;

		public static void Clear()
		{
		}

		public static void Clear(object cacheType)
		{
		}

		public static ICache<TKey, TValue> GetCache<TKey, TValue>(object client, object cacheIdentifier, IEqualityComparer<TKey> keyComparer)
		{
			return null;
		}

		public static ICache<TKey, TValue> GetCache<TKey, TValue>(AmazonServiceClient client, object cacheIdentifier, IEqualityComparer<TKey> keyComparer)
		{
			return null;
		}
	}
}
