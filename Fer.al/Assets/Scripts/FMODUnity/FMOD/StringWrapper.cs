using System;

namespace FMOD
{
	public struct StringWrapper
	{
		private IntPtr nativeUtf8Ptr;

		public StringWrapper(IntPtr ptr)
		{
		}

		public static implicit operator string(StringWrapper fstring)
		{
			return null;
		}
	}
}
