using System;
using System.Runtime.InteropServices;

namespace Rewired
{
	[ComVisible(false)]
	[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Interface)]
	internal sealed class CustomClassObfuscation : Attribute
	{
		public bool renamePubIntMembers;

		public bool renamePrivateMembers;
	}
}
