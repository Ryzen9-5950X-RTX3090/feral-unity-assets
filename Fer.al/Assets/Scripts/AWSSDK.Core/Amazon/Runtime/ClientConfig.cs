using System;
using System.Collections.Generic;
using System.Net;
using System.Runtime.CompilerServices;

namespace Amazon.Runtime
{
	public abstract class ClientConfig : IClientConfig
	{
		internal static readonly TimeSpan InfiniteTimeout;

		public static readonly TimeSpan MaxTimeout;

		private RegionEndpoint regionEndpoint;

		private bool probeForRegionEndpoint;

		private bool throttleRetries;

		private bool useHttp;

		private string serviceURL;

		private string authRegion;

		private string authServiceName;

		private string signatureVersion;

		private SigningAlgorithm signatureMethod;

		private bool readEntireResponse;

		private bool logResponse;

		private int bufferSize;

		private long progressUpdateInterval;

		private bool resignRetries;

		private ICredentials proxyCredentials;

		private bool logMetrics;

		private bool disableLogging;

		private TimeSpan? timeout;

		private bool allowAutoRedirect;

		private bool useDualstackEndpoint;

		private TimeSpan? readWriteTimeout;

		private bool disableHostPrefixInjection;

		private bool? endpointDiscoveryEnabled;

		private int endpointDiscoveryCacheLimit;

		private RequestRetryMode? retryMode;

		private int? maxRetries;

		private const int MaxRetriesDefault = 2;

		private const int MaxRetriesLegacyDefault = 4;

		private string proxyHost;

		private int proxyPort;

		private List<string> proxyBypassList;

		private int? connectionLimit;

		private int? maxIdleTime;

		private bool useNagleAlgorithm;

		public abstract string ServiceVersion { get; }

		public SigningAlgorithm SignatureMethod
		{
			get
			{
				return default(SigningAlgorithm);
			}
			set
			{
			}
		}

		public string SignatureVersion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public abstract string UserAgent { get; }

		public RegionEndpoint RegionEndpoint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public abstract string RegionEndpointServiceName { get; }

		public string ServiceURL
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseHttp
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public string AuthenticationRegion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string AuthenticationServiceName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int MaxErrorRetry
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool IsMaxErrorRetrySet
		{
			get
			{
				return default(bool);
			}
		}

		public bool LogResponse
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[Obsolete]
		public bool ReadEntireResponse
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int BufferSize
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public long ProgressUpdateInterval
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		public bool ResignRetries
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool AllowAutoRedirect
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool LogMetrics
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool DisableLogging
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public ICredentials ProxyCredentials
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public TimeSpan? Timeout
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool UseDualstackEndpoint
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool ThrottleRetries
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		[Obsolete]
		public DateTime CorrectedUtcNow
		{
			get
			{
				return default(DateTime);
			}
		}

		public TimeSpan ClockOffset
		{
			get
			{
				return default(TimeSpan);
			}
		}

		public bool DisableHostPrefixInjection
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool EndpointDiscoveryEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public int EndpointDiscoveryCacheLimit
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public RequestRetryMode RetryMode
		{
			get
			{
				return default(RequestRetryMode);
			}
			set
			{
			}
		}

		public bool FastFailRequests
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public TimeSpan? ReadWriteTimeout
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string ProxyHost
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public int ProxyPort
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public List<string> ProxyBypassList
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool ProxyBypassOnLocal
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public int MaxIdleTime
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int ConnectionLimit
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool UseNagleAlgorithm
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public virtual string DetermineServiceURL()
		{
			return null;
		}

		internal static string GetUrl(RegionEndpoint regionEndpoint, string regionEndpointServiceName, bool useHttp, bool useDualStack)
		{
			return null;
		}

		public ClientConfig()
		{
		}

		protected virtual void Initialize()
		{
		}

		public void SetUseNagleIfAvailable(bool useNagle)
		{
		}

		public virtual void Validate()
		{
		}

		public static void ValidateTimeout(TimeSpan? timeout)
		{
		}

		public static TimeSpan? GetTimeoutValue(TimeSpan? clientTimeout, TimeSpan? requestTimeout)
		{
			return null;
		}

		private static RegionEndpoint GetDefaultRegionEndpoint()
		{
			return null;
		}

		public WebProxy GetWebProxy()
		{
			return null;
		}

		public void SetWebProxy(WebProxy proxy)
		{
		}
	}
}
