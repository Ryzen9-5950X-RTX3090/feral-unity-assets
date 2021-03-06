using System;
using System.Runtime.InteropServices;

namespace FMOD
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct Factory
	{
		public static RESULT System_Create(out System system)
		{
			return default(RESULT);
		}

		private static extern RESULT FMOD5_System_Create(out IntPtr system);
	}
}
