using System;
using System.Runtime.InteropServices;
using Backtrace.Unity.Types;

namespace Backtrace.Unity.Common
{
	[StructLayout(LayoutKind.Sequential, Pack = 4, Size = 16)]
	internal struct MiniDumpExceptionInformation
	{
		internal uint ThreadId;

		internal IntPtr ExceptionPointers;

		internal bool ClientPointers;

		internal static MiniDumpExceptionInformation GetInstance(MinidumpException exceptionInfo)
		{
			return default(MiniDumpExceptionInformation);
		}
	}
}
