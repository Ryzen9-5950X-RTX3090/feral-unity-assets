using System;
using System.Text.RegularExpressions;

namespace Newtonsoft.Json.Utilities
{
	internal static class MiscellaneousUtils
	{
		public static bool ValueEquals(object objA, object objB)
		{
			return default(bool);
		}

		public static ArgumentOutOfRangeException CreateArgumentOutOfRangeException(string paramName, object actualValue, string message)
		{
			return null;
		}

		public static string ToString(object value)
		{
			return null;
		}

		public static int ByteArrayCompare(byte[] a1, byte[] a2)
		{
			return default(int);
		}

		public static string GetPrefix(string qualifiedName)
		{
			return null;
		}

		public static string GetLocalName(string qualifiedName)
		{
			return null;
		}

		public static void GetQualifiedNameParts(string qualifiedName, out string prefix, out string localName)
		{
		}

		internal static RegexOptions GetRegexOptions(string optionsText)
		{
			return default(RegexOptions);
		}
	}
}
