using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Xml.Linq;
using Amazon.Util;
using Amazon.Util.Internal;

namespace Amazon
{
	public static class AWSConfigs
	{
		public enum HttpClientOption
		{
			UnityWWW,
			UnityWebRequest
		}

		private static char[] validSeparators;

		internal static Func<DateTime> utcNowSource;

		internal static string _awsRegion;

		internal static LoggingOptions _logging;

		internal static ResponseLoggingOption _responseLogging;

		internal static bool _logMetrics;

		internal static string _endpointDefinition;

		internal static string _awsProfileName;

		internal static string _awsAccountsLocation;

		internal static bool _useSdkCache;

		private static object _lock;

		private static List<string> standardConfigs;

		private static bool configPresent;

		private static RootConfig _rootConfig;

		public const string AWSRegionKey = "AWSRegion";

		public const string AWSProfileNameKey = "AWSProfileName";

		public const string AWSProfilesLocationKey = "AWSProfilesLocation";

		public const string LoggingKey = "AWSLogging";

		public const string ResponseLoggingKey = "AWSResponseLogging";

		public const string LogMetricsKey = "AWSLogMetrics";

		public const string EndpointDefinitionKey = "AWSEndpointDefinition";

		public const string UseSdkCacheKey = "AWSCache";

		internal const string LoggingDestinationProperty = "LogTo";

		internal static PropertyChangedEventHandler mPropertyChanged;

		internal static readonly object propertyChangedLock;

		private static HttpClientOption _httpClient;

		internal static bool UnityWebRequestInitialized;

		internal static Dictionary<string, List<TraceListener>> _traceListeners;

		private const string CONFIG_FILE = "awsconfig";

		internal static XDocument xmlDoc;

		public static TimeSpan? ManualClockCorrection
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool CorrectForClockSkew
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
		public static TimeSpan ClockOffset
		{
			[CompilerGenerated]
			get
			{
				return default(TimeSpan);
			}
			[CompilerGenerated]
			internal set
			{
			}
		}

		public static string AWSRegion
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string AWSProfileName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string AWSProfilesLocation
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		[Obsolete]
		public static LoggingOptions Logging
		{
			get
			{
				return default(LoggingOptions);
			}
			set
			{
			}
		}

		[Obsolete]
		public static ResponseLoggingOption ResponseLogging
		{
			get
			{
				return default(ResponseLoggingOption);
			}
			set
			{
			}
		}

		[Obsolete]
		public static bool LogMetrics
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public static string EndpointDefinition
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static bool UseSdkCache
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public static LoggingConfig LoggingConfig
		{
			get
			{
				return null;
			}
		}

		public static ProxyConfig ProxyConfig
		{
			get
			{
				return null;
			}
		}

		public static RegionEndpoint RegionEndpoint
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static CSMConfig CSMConfig
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string ApplicationName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static HttpClientOption HttpClient
		{
			get
			{
				return default(HttpClientOption);
			}
			set
			{
			}
		}

		internal static event PropertyChangedEventHandler PropertyChanged
		{
			add
			{
			}
			remove
			{
			}
		}

		private static LoggingOptions GetLoggingSetting()
		{
			return default(LoggingOptions);
		}

		internal static void OnPropertyChanged(string name)
		{
		}

		private static bool GetConfigBool(string name, bool defaultValue = false)
		{
			return default(bool);
		}

		private static T GetConfigEnum<T>(string name)
		{
			return (T)null;
		}

		private static T ParseEnum<T>(string value)
		{
			return (T)null;
		}

		private static bool TryParseEnum<T>(string value, out T result)
		{
			return default(bool);
		}

		private static DateTime GetUtcNow()
		{
			return default(DateTime);
		}

		public static string GetConfig(string name)
		{
			return null;
		}

		internal static T GetSection<T>(string sectionName) where T : AWSSection, new()
		{
			return null;
		}

		internal static bool XmlSectionExists(string sectionName)
		{
			return default(bool);
		}

		public static void AddTraceListener(string source, TraceListener listener)
		{
		}

		public static void RemoveTraceListener(string source, string name)
		{
		}

		internal static TraceListener[] TraceListeners(string source)
		{
			return null;
		}

		private static XDocument LoadConfigFromResource()
		{
			return null;
		}

		public static T GetObject<T>(XElement rootElement, string propertyName) where T : class, new()
		{
			return null;
		}

		private static object GetObject(XElement rootElement, string propertyName, Type type)
		{
			return null;
		}

		private static IEnumerable GetList(XElement rootElement, Type listType, string propertyName)
		{
			return null;
		}

		private static IDictionary<string, XElement> GetUnresolvedElements(XElement parent)
		{
			return null;
		}
	}
}
