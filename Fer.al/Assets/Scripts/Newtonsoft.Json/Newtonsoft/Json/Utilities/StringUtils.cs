using System;
using System.Collections.Generic;
using System.IO;

namespace Newtonsoft.Json.Utilities
{
	internal static class StringUtils
	{
		public static string FormatWith(this string format, IFormatProvider provider, object arg0)
		{
			return null;
		}

		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1)
		{
			return null;
		}

		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2)
		{
			return null;
		}

		public static string FormatWith(this string format, IFormatProvider provider, object arg0, object arg1, object arg2, object arg3)
		{
			return null;
		}

		private static string FormatWith(this string format, IFormatProvider provider, object[] args)
		{
			return null;
		}

		public static StringWriter CreateStringWriter(int capacity)
		{
			return null;
		}

		public static void ToCharAsUnicode(char c, char[] buffer)
		{
		}

		public static TSource ForgivingCaseSensitiveFind<TSource>(this IEnumerable<TSource> source, Func<TSource, string> valueSelector, string testValue)
		{
			return (TSource)null;
		}

		public static string ToCamelCase(string s)
		{
			return null;
		}

		private static char ToLower(char c)
		{
			return default(char);
		}

		public static bool IsHighSurrogate(char c)
		{
			return default(bool);
		}

		public static bool IsLowSurrogate(char c)
		{
			return default(bool);
		}

		public static bool StartsWith(this string source, char value)
		{
			return default(bool);
		}

		public static bool EndsWith(this string source, char value)
		{
			return default(bool);
		}

		public static string Trim(this string s, int start, int length)
		{
			return null;
		}
	}
}
