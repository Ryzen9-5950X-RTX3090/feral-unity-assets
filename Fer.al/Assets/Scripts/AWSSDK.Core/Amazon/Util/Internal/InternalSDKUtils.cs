using System;
using System.Collections.Generic;
using Amazon.Runtime;
using Amazon.Runtime.Internal.Util;

namespace Amazon.Util.Internal
{
	public static class InternalSDKUtils
	{
		internal const string UnknownVersion = "Unknown";

		internal const string UnknownNetFrameworkVersion = ".NET_Runtime/Unknown .NET_Framework/Unknown";

		private static string _versionNumber;

		private static string _customSdkUserAgent;

		private static string _customData;

		internal const string CoreVersionNumber = "3.3.107.40";

		private static string _userAgentBaseName;

		private const string UnknownMonoVersion = "Mono/Unknown";

		private static Logger _logger;

		public static bool IsAndroid
		{
			get
			{
				return default(bool);
			}
		}

		public static bool IsiOS
		{
			get
			{
				return default(bool);
			}
		}

		public static void SetUserAgent(string productName, string versionNumber)
		{
		}

		public static void SetUserAgent(string productName, string versionNumber, string customData)
		{
		}

		private static void BuildCustomUserAgentString()
		{
		}

		public static string BuildUserAgentString(string serviceSdkVersion)
		{
			return null;
		}

		public static void ApplyValues(object target, IDictionary<string, object> propertyValues)
		{
		}

		public static void AddToDictionary<TKey, TValue>(Dictionary<TKey, TValue> dictionary, TKey key, TValue value)
		{
		}

		public static void FillDictionary<T, TKey, TValue>(IEnumerable<T> items, Func<T, TKey> keyGenerator, Func<T, TValue> valueGenerator, Dictionary<TKey, TValue> targetDictionary)
		{
		}

		public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue, T>(IEnumerable<T> items, Func<T, TKey> keyGenerator, Func<T, TValue> valueGenerator)
		{
			return null;
		}

		public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue, T>(IEnumerable<T> items, Func<T, TKey> keyGenerator, Func<T, TValue> valueGenerator, IEqualityComparer<TKey> comparer)
		{
			return null;
		}

		public static bool TryFindByValue<TKey, TValue>(IDictionary<TKey, TValue> dictionary, TValue value, IEqualityComparer<TValue> valueComparer, out TKey key)
		{
			return default(bool);
		}

		public static void SetIsSet<T>(bool isSet, ref T? field) where T : struct
		{
		}

		public static void SetIsSet<T>(bool isSet, ref List<T> field)
		{
		}

		public static void SetIsSet<TKey, TValue>(bool isSet, ref Dictionary<TKey, TValue> field)
		{
		}

		public static bool GetIsSet<T>(T? field) where T : struct
		{
			return default(bool);
		}

		public static bool GetIsSet<T>(List<T> field)
		{
			return default(bool);
		}

		public static bool GetIsSet<TKey, TVvalue>(Dictionary<TKey, TVvalue> field)
		{
			return default(bool);
		}

		public static string GetMonoRuntimeVersion()
		{
			return null;
		}

		internal static Type GetTypeFromUnityEngine(string typeName)
		{
			return null;
		}

		public static void AsyncExecutor(Action action, AsyncOptions options)
		{
		}

		public static void SafeExecute(Action action)
		{
		}
	}
}
