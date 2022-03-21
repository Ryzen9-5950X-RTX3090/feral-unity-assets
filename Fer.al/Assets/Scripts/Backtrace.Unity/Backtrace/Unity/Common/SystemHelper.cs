using System;

namespace Backtrace.Unity.Common
{
	internal static class SystemHelper
	{
		internal static extern uint GetCurrentThreadId();

		internal static extern IntPtr LoadLibrary(string lpFileName);

		internal static bool IsLibraryAvailable(string libraryName)
		{
			return default(bool);
		}

		internal static bool IsLibraryAvailable(string[] libraries)
		{
			return default(bool);
		}

		internal static string Name()
		{
			return null;
		}

		internal static string CpuArchitecture()
		{
			return null;
		}
	}
}
