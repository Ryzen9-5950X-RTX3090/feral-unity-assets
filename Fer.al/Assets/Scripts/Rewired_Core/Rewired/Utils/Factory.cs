using System;
using System.Runtime.InteropServices;

namespace Rewired.Utils
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal static class Factory
	{
		public static object CreateInstance(Type type, [Optional] object[] args)
		{
			return null;
		}
	}
}
