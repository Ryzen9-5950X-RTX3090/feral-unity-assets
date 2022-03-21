using System;

namespace Rewired.Utils.Attributes
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	[AttributeUsage(AttributeTargets.All)]
	public class PreserveAttribute : Attribute
	{
	}
}
