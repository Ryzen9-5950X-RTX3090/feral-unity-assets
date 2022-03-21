using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.IO;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;

namespace BestHTTP.Extensions
{
	public static class Extensions
	{
		private static readonly Regex validIpV4AddressRegex;

		public static string AsciiToString(this byte[] bytes)
		{
			return null;
		}

		public static byte[] GetASCIIBytes(this string str)
		{
			return null;
		}

		public static void SendAsASCII(this BinaryWriter stream, string str)
		{
		}

		public static void WriteLine(this Stream fs)
		{
		}

		public static void WriteLine(this Stream fs, string line)
		{
		}

		public static void WriteLine(this Stream fs, string format, object[] values)
		{
		}

		public static string GetRequestPathAndQueryURL(this Uri uri)
		{
			return null;
		}

		public static string[] FindOption(this string str, string option)
		{
			return null;
		}

		public static string[] FindOption(this string[] options, string option)
		{
			return null;
		}

		public static void WriteArray(this Stream stream, byte[] array)
		{
		}

		public static bool IsHostIsAnIPAddress(this Uri uri)
		{
			return default(bool);
		}

		public static bool IsIpV4AddressValid(string address)
		{
			return default(bool);
		}

		public static bool IsIpV6AddressValid(string address)
		{
			return default(bool);
		}

		public static int ToInt32(this string str, int defaultValue = 0)
		{
			return default(int);
		}

		public static long ToInt64(this string str, long defaultValue = 0L)
		{
			return default(long);
		}

		public static DateTime ToDateTime(this string str, [Optional] DateTime defaultValue)
		{
			return default(DateTime);
		}

		public static string ToStrOrEmpty(this string str)
		{
			return null;
		}

		public static string ToStr(this string str, string defaultVale)
		{
			return null;
		}

		public static string ToBinaryStr(this byte value)
		{
			return null;
		}

		public static string CalculateMD5Hash(this string input)
		{
			return null;
		}

		public static string CalculateMD5Hash(this byte[] input)
		{
			return null;
		}

		internal static string Read(this string str, ref int pos, char block, bool needResult = true)
		{
			return null;
		}

		internal static string Read(this string str, ref int pos, Func<char, bool> block, bool needResult = true)
		{
			return null;
		}

		internal static string ReadPossibleQuotedText(this string str, ref int pos)
		{
			return null;
		}

		internal static void SkipWhiteSpace(this string str, ref int pos)
		{
		}

		internal static string TrimAndLower(this string str)
		{
			return null;
		}

		internal static char? Peek(this string str, int pos)
		{
			return null;
		}

		internal static List<HeaderValue> ParseOptionalHeader(this string str)
		{
			return null;
		}

		internal static List<HeaderValue> ParseQualityParams(this string str)
		{
			return null;
		}

		public static void ReadBuffer(this Stream stream, byte[] buffer)
		{
		}

		public static void ReadBuffer(this Stream stream, byte[] buffer, int length)
		{
		}

		public static void WriteString(this BufferPoolMemoryStream ms, string str)
		{
		}

		public static void WriteLine(this BufferPoolMemoryStream ms)
		{
		}

		public static void WriteLine(this BufferPoolMemoryStream ms, string str)
		{
		}

		public static void Clear<T>(this ConcurrentQueue<T> queue)
		{
		}
	}
}
