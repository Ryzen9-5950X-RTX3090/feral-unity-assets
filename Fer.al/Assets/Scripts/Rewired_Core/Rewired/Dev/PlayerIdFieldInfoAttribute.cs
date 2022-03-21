using System;

namespace Rewired.Dev
{
	[AttributeUsage(AttributeTargets.Field)]
	public class PlayerIdFieldInfoAttribute : Attribute
	{
		public string friendlyName;
	}
}
