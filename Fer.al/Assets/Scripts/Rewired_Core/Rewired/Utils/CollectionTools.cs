using System;
using System.Collections;
using System.Collections.Generic;

namespace Rewired.Utils
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal static class CollectionTools
	{
		public static Dictionary<TValue, TKey> CreateInverseDictionary<TValue, TKey>(Dictionary<TKey, TValue> dict)
		{
			return null;
		}

		public static TReturn GetDictionaryValueSafe<TReturn>(Dictionary<string, object> dictionary, string key)
		{
			return (TReturn)null;
		}

		public static TReturn GetDictionaryValueSafe<TReturn>(Dictionary<string, object> dictionary, string key, out bool success)
		{
			return (TReturn)null;
		}

		public static TValue GetDictionaryValueSafe<TValue, TKey>(Dictionary<TKey, TValue> dictionary, TKey key)
		{
			return (TValue)null;
		}

		public static TValue GetDictionaryValueSafe<TValue, TKey>(Dictionary<TKey, TValue> dictionary, TKey key, out bool success)
		{
			return (TValue)null;
		}

		public static bool GetDictionaryValueSafe<TReturn>(Dictionary<string, object> dictionary, string key, ref TReturn value)
		{
			return default(bool);
		}

		public static bool GetDictionaryValueSafe(Dictionary<string, object> dictionary, string key, Type type, ref object value)
		{
			return default(bool);
		}

		public static bool GetDictionaryValueSafe_float(Dictionary<string, object> dictionary, string key, ref float value)
		{
			return default(bool);
		}

		public static bool GetDictionaryValueSafe_int(Dictionary<string, object> dictionary, string key, ref int value)
		{
			return default(bool);
		}

		public static void AddValueSafe(Dictionary<string, object> data, string key, object value)
		{
		}

		public static T GetValue<T>(IEnumerable<T> enumerable, int index)
		{
			return (T)null;
		}

		public static T GetValue<T>(IEnumerable enumerable, int index)
		{
			return (T)null;
		}
	}
}
