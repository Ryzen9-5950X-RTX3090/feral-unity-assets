using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

namespace Crosstales
{
	public static class ExtensionMethods
	{
		public static string CTToTitleCase(this string str)
		{
			return null;
		}

		public static string CTReverse(this string str)
		{
			return null;
		}

		public static string CTReplace(this string str, string oldString, string newString, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return null;
		}

		public static bool CTEquals(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		public static bool CTContains(this string str, string toCheck, StringComparison comp = StringComparison.OrdinalIgnoreCase)
		{
			return default(bool);
		}

		public static bool CTContainsAny(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		public static bool CTContainsAll(this string str, string searchTerms, char splitChar = ' ')
		{
			return default(bool);
		}

		public static bool CTisNumeric(this string str)
		{
			return default(bool);
		}

		public static void CTShuffle<T>(this T[] array, int seed = 0)
		{
		}

		public static string CTDump<T>(this T[] array, string prefix = "", string postfix = "")
		{
			return null;
		}

		public static string CTDump(this Quaternion[] array)
		{
			return null;
		}

		public static string CTDump(this Vector2[] array)
		{
			return null;
		}

		public static string CTDump(this Vector3[] array)
		{
			return null;
		}

		public static string CTDump(this Vector4[] array)
		{
			return null;
		}

		public static string[] CTToString<T>(this T[] array)
		{
			return null;
		}

		public static void CTShuffle<T>(this IList<T> list, int seed = 0)
		{
		}

		public static string CTDump<T>(this IList<T> list, string prefix = "", string postfix = "")
		{
			return null;
		}

		public static string CTDump(this IList<Quaternion> list)
		{
			return null;
		}

		public static string CTDump(this IList<Vector2> list)
		{
			return null;
		}

		public static string CTDump(this IList<Vector3> list)
		{
			return null;
		}

		public static string CTDump(this IList<Vector4> list)
		{
			return null;
		}

		public static List<string> CTToString<T>(this IList<T> list)
		{
			return null;
		}

		public static string CTDump<K, V>(this IDictionary<K, V> dict, string prefix = "", string postfix = "")
		{
			return null;
		}

		public static void CTAddRange<K, V>(this IDictionary<K, V> source, IDictionary<K, V> collection)
		{
		}

		public static bool CTIsVisibleFrom(this Renderer renderer, Camera camera)
		{
			return default(bool);
		}

		public static Transform CTDeepSearch(Transform parent, string name)
		{
			return null;
		}

		public static byte[] CTReadFully(this Stream input, int bufferSize = 16384)
		{
			return null;
		}
	}
}
