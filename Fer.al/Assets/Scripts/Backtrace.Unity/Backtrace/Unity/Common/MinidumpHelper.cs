using System;
using System.Runtime.InteropServices;
using Backtrace.Unity.Types;

namespace Backtrace.Unity.Common
{
	internal static class MinidumpHelper
	{
		private static readonly string[] Libraries;

		private static bool IsMemoryDumpAvailable()
		{
			return default(bool);
		}

		internal static extern bool MiniDumpWriteDump(IntPtr hProcess, uint processId, SafeHandle hFile, uint dumpType, ref MiniDumpExceptionInformation expParam, IntPtr userStreamParam, IntPtr callbackParam);

		internal static extern bool MiniDumpWriteDump(IntPtr hProcess, uint processId, SafeHandle hFile, uint dumpType, IntPtr expParam, IntPtr userStreamParam, IntPtr callbackParam);

		internal static bool Write(string filePath, MiniDumpType options = MiniDumpType.WithFullMemory, MinidumpException exceptionType = MinidumpException.None)
		{
			return default(bool);
		}
	}
}
