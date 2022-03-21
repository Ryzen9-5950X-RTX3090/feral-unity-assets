using System;
using System.Runtime.InteropServices;

namespace Rewired
{
	[AttributeUsage(AttributeTargets.All)]
	[ComVisible(false)]
	internal sealed class CustomObfuscation : Attribute
	{
		public bool rename;
	}
}
