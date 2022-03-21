using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Text.RegularExpressions;
using UnityEngine;

namespace Candlelight
{
	public static class StringX
	{
		private delegate bool ParseEnumCallback(string value, out object parsedValue);

		public struct StringBuilderScope : IDisposable
		{
			private StringBuilder m_StringBuilder;

			public StringBuilder StringBuilder
			{
				get
				{
					return null;
				}
			}

			public void Dispose()
			{
			}
		}

		private static readonly Dictionary<Type, ParseEnumCallback> s_EnumParsers;

		private static readonly Regex s_MatchBaseName;

		private static readonly int s_MatchBaseNameNameGroup;

		private static readonly int s_MatchBaseNameNumberGroup;

		private static readonly ObjectPool<StringBuilder> s_StringBuilderPool;

		private static readonly TextInfo s_TitleCaseTextInfo;

		public static bool ContainsLowercase(this string str)
		{
			return default(bool);
		}

		public static bool ContainsUppercase(this string str)
		{
			return default(bool);
		}

		public static string GetUniqueName(this string baseName, IList<string> existingNames)
		{
			return null;
		}

		public static string GetUniqueName(this string baseName, HashSet<string> existingNames)
		{
			return null;
		}

		public static string Join(this string separator, IEnumerable<string> strings)
		{
			return null;
		}

		public static string Range(this string str, int start, int end = -1, int skip = 1)
		{
			return null;
		}

		public static string ToFeetInchesString(this float meters)
		{
			return null;
		}

		public static string ToHexString(this Color color)
		{
			return null;
		}

		public static string ToSnakeCase(this string compoundWord)
		{
			return null;
		}

		public static string ToTimeString(this float time)
		{
			return null;
		}

		public static string ToTitleCase(this string words)
		{
			return null;
		}

		public static string ToWords(this string compoundWord)
		{
			return null;
		}

		public static bool TryParseNumberStringAsEnum(Type enumType, string numberString, out object enumValue)
		{
			return default(bool);
		}
	}
}
