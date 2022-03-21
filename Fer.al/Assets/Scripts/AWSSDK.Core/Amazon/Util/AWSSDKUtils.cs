using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Reflection;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Util
{
	public static class AWSSDKUtils
	{
		internal const string DefaultRegion = "us-east-1";

		internal const string DefaultGovRegion = "us-gov-west-1";

		private const char WindowsDirectorySeparatorChar = '\\';

		private const char WindowsAltDirectorySeparatorChar = '/';

		private const char WindowsVolumeSeparatorChar = ':';

		private const char SlashChar = '/';

		private const string Slash = "/";

		private const string EncodedSlash = "%2F";

		internal const int DefaultMaxRetry = 3;

		private const int DefaultConnectionLimit = 50;

		private const int DefaultMaxIdleTime = 50000;

		public static readonly DateTime EPOCH_START;

		public const int DefaultBufferSize = 8192;

		public const long DefaultProgressUpdateInterval = 102400L;

		internal static Dictionary<int, string> RFCEncodingSchemes;

		internal const string S3Accelerate = "s3-accelerate";

		internal const string S3Control = "s3-control";

		private const int DefaultMarshallerVersion = 1;

		private static readonly string _userAgent;

		public const string UserAgentHeader = "User-Agent";

		public const string ValidUrlCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.~";

		public const string ValidUrlCharactersRFC1738 = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789-_.";

		private static string ValidPathCharacters;

		public const string UrlEncodedContent = "application/x-www-form-urlencoded; charset=utf-8";

		public const string GMTDateFormat = "ddd, dd MMM yyyy HH:mm:ss \\G\\M\\T";

		public const string ISO8601DateFormat = "yyyy-MM-dd\\THH:mm:ss.fff\\Z";

		public const string ISO8601DateFormatNoMS = "yyyy-MM-dd\\THH:mm:ss\\Z";

		public const string ISO8601BasicDateTimeFormat = "yyyyMMddTHHmmssZ";

		public const string ISO8601BasicDateFormat = "yyyyMMdd";

		public const string RFC822DateFormat = "ddd, dd MMM yyyy HH:mm:ss \\G\\M\\T";

		private static BackgroundInvoker _dispatcher;

		private static readonly object _preserveStackTraceLookupLock;

		private static bool _preserveStackTraceLookup;

		private static MethodInfo _preserveStackTrace;

		private const int _defaultDefaultConnectionLimit = 2;

		private const int _defaultMaxIdleTime = 100000;

		private static BackgroundInvoker Dispatcher
		{
			get
			{
				return null;
			}
		}

		public static string FormattedCurrentTimestampGMT
		{
			get
			{
				return null;
			}
		}

		public static string FormattedCurrentTimestampISO8601
		{
			get
			{
				return null;
			}
		}

		public static string FormattedCurrentTimestampRFC822
		{
			get
			{
				return null;
			}
		}

		[Obsolete]
		public static DateTime CorrectedUtcNow
		{
			get
			{
				return default(DateTime);
			}
		}

		internal static bool IsIL2CPP
		{
			get
			{
				return default(bool);
			}
		}

		private static string DetermineValidPathCharacters()
		{
			return null;
		}

		public static string GetExtension(string path)
		{
			return null;
		}

		private static bool IsPathSeparator(char ch)
		{
			return default(bool);
		}

		internal static string CalculateStringToSignV2(ParameterCollection parameterCollection, string serviceUrl)
		{
			return null;
		}

		internal static string GetParametersAsString(IRequest request)
		{
			return null;
		}

		internal static string GetParametersAsString(ParameterCollection parameterCollection)
		{
			return null;
		}

		public static string CanonicalizeResourcePath(Uri endpoint, string resourcePath)
		{
			return null;
		}

		public static string CanonicalizeResourcePath(Uri endpoint, string resourcePath, bool detectPreEncode)
		{
			return null;
		}

		public static string CanonicalizeResourcePath(Uri endpoint, string resourcePath, bool detectPreEncode, IDictionary<string, string> pathResources, int marshallerVersion)
		{
			return null;
		}

		public static IEnumerable<string> SplitResourcePathIntoSegments(string resourcePath, IDictionary<string, string> pathResources)
		{
			return null;
		}

		public static string JoinResourcePathSegments(IEnumerable<string> pathSegments, bool path)
		{
			return null;
		}

		public static string ResolveResourcePath(string resourcePath, IDictionary<string, string> pathResources)
		{
			return null;
		}

		public static string Join(List<string> strings)
		{
			return null;
		}

		public static string DetermineRegion(string url)
		{
			return null;
		}

		public static string DetermineService(string url)
		{
			return null;
		}

		public static DateTime ConvertFromUnixEpochSeconds(int seconds)
		{
			return default(DateTime);
		}

		public static int ConvertToUnixEpochSeconds(DateTime dateTime)
		{
			return default(int);
		}

		public static string ConvertToUnixEpochSecondsString(DateTime dateTime)
		{
			return null;
		}

		[Obsolete]
		public static double ConvertToUnixEpochMilliSeconds(DateTime dateTime)
		{
			return default(double);
		}

		public static double ConvertToUnixEpochSecondsDouble(DateTime dateTime)
		{
			return default(double);
		}

		public static TimeSpan GetTimeSpanInTicks(DateTime dateTime)
		{
			return default(TimeSpan);
		}

		public static long ConvertDateTimetoMilliseconds(DateTime dateTime)
		{
			return default(long);
		}

		public static long ConvertTimeSpanToMilliseconds(TimeSpan timeSpan)
		{
			return default(long);
		}

		public static string ToHex(byte[] data, bool lowercase)
		{
			return null;
		}

		public static void InvokeInBackground<T>(EventHandler<T> handler, T args, object sender) where T : EventArgs
		{
		}

		public static Dictionary<string, string> ParseQueryParameters(string url)
		{
			return null;
		}

		internal static bool AreEqual(object[] itemsA, object[] itemsB)
		{
			return default(bool);
		}

		internal static bool AreEqual(object a, object b)
		{
			return default(bool);
		}

		internal static bool DictionariesAreEqual<K, V>(Dictionary<K, V> a, Dictionary<K, V> b)
		{
			return default(bool);
		}

		public static MemoryStream GenerateMemoryStreamFromString(string s)
		{
			return null;
		}

		public static void CopyStream(Stream source, Stream destination)
		{
		}

		public static void CopyStream(Stream source, Stream destination, int bufferSize)
		{
		}

		public static string GetFormattedTimestampISO8601(int minutesFromNow)
		{
			return null;
		}

		internal static string GetFormattedTimestampISO8601(IClientConfig config)
		{
			return null;
		}

		private static string GetFormattedTimestampISO8601(DateTime dateTime)
		{
			return null;
		}

		public static string GetFormattedTimestampRFC822(int minutesFromNow)
		{
			return null;
		}

		public static bool IsAbsolutePath(string path)
		{
			return default(bool);
		}

		private static bool IsWindows()
		{
			return default(bool);
		}

		private static bool IsPartiallyQualifiedForWindows(string path)
		{
			return default(bool);
		}

		private static bool IsWindowsDirectorySeparator(char c)
		{
			return default(bool);
		}

		private static bool IsValidWindowsDriveChar(char value)
		{
			return default(bool);
		}

		public static string UrlEncode(string data, bool path)
		{
			return null;
		}

		public static string UrlEncode(int rfcNumber, string data, bool path)
		{
			return null;
		}

		internal static string UrlEncodeSlash(string data)
		{
			return null;
		}

		public static string ProtectEncodedSlashUrlEncode(string data, bool path)
		{
			return null;
		}

		public static void Sleep(TimeSpan ts)
		{
		}

		public static string BytesToHexString(byte[] value)
		{
			return null;
		}

		public static byte[] HexStringToBytes(string hex)
		{
			return null;
		}

		public static bool HasBidiControlCharacters(string input)
		{
			return default(bool);
		}

		private static bool IsBidiControlChar(char c)
		{
			return default(bool);
		}

		public static string DownloadStringContent(Uri uri)
		{
			return null;
		}

		public static string DownloadStringContent(Uri uri, TimeSpan timeout)
		{
			return null;
		}

		public static string DownloadStringContent(Uri uri, IWebProxy proxy)
		{
			return null;
		}

		public static string DownloadStringContent(Uri uri, TimeSpan timeout, IWebProxy proxy)
		{
			return null;
		}

		public static string ExecuteHttpRequest(Uri uri, string requestType, string content, TimeSpan timeout, IWebProxy proxy, IDictionary<string, string> headers)
		{
			return null;
		}

		private static HttpWebRequest CreateClient(Uri uri, TimeSpan timeout, IWebProxy proxy, IDictionary<string, string> headers)
		{
			return null;
		}

		public static Stream OpenStream(Uri uri)
		{
			return null;
		}

		public static Stream OpenStream(Uri uri, IWebProxy proxy)
		{
			return null;
		}

		public static string CompressSpaces(string data)
		{
			return null;
		}

		public static void ForceCanonicalPathAndQuery(Uri uri)
		{
		}

		public static void PreserveStackTrace(Exception exception)
		{
		}

		internal static int GetConnectionLimit(int? clientConfigValue)
		{
			return default(int);
		}

		internal static int GetMaxIdleTime(int? clientConfigValue)
		{
			return default(int);
		}

		public static void Sleep(int ms)
		{
		}
	}
}
