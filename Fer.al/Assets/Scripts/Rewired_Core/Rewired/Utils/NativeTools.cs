using System;

namespace Rewired.Utils
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal static class NativeTools
	{
		private static byte[] VQWvhhNdJjshCTxywtnOnztLQzw;

		public static IntPtr OffsetIntPtr(IntPtr intPtr, int offset)
		{
			return default(IntPtr);
		}

		public static bool CopyMemory(IntPtr source, IntPtr destination, int sourceStartIndex, int destinationStartIndex, int bytesToCopy, bool throwOnError = true)
		{
			return default(bool);
		}

		public static bool CopyMemory(byte[] source, IntPtr destination, int sourceStartIndex, int destinationStartIndex, int bytesToCopy, bool throwOnError = true)
		{
			return default(bool);
		}

		public static bool CopyMemory(IntPtr source, byte[] destination, int sourceStartIndex, int destinationStartIndex, int bytesToCopy, bool throwOnError = true)
		{
			return default(bool);
		}

		public static bool FillMemory(IntPtr buffer, int length, byte value, bool throwOnError = true)
		{
			return default(bool);
		}

		public static bool FillMemory(IntPtr buffer, int startIndex, int length, byte value, bool throwOnError = true)
		{
			return default(bool);
		}

		public static bool FillMemory(byte[] buffer, int length, byte value, bool throwOnError = true)
		{
			return default(bool);
		}

		public static bool FillMemory(byte[] buffer, int startIndex, int length, byte value, bool throwOnError = true)
		{
			return default(bool);
		}

		public static void ZeroFillMemory(IntPtr buffer, int length)
		{
		}

		public static string DumpToString(IntPtr buffer, int length, string stringFormat = "x2")
		{
			return null;
		}

		public static void FreeHGlobalSafe(ref IntPtr pointer)
		{
		}
	}
}
