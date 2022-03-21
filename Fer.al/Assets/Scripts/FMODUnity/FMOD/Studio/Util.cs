using System;
using System.Runtime.InteropServices;

namespace FMOD.Studio
{
	[StructLayout(LayoutKind.Sequential, Size = 1)]
	public struct Util
	{
		public static RESULT parseID(string idString, out Guid id)
		{
			return default(RESULT);
		}

		private static extern RESULT FMOD_Studio_ParseID(byte[] idString, out Guid id);
	}
}
