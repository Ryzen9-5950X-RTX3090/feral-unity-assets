using System;

namespace Rewired.Dev
{
	[AttributeUsage(AttributeTargets.Field)]
	public class ActionIdFieldInfoAttribute : Attribute
	{
		public string categoryName;

		public string friendlyName;
	}
}
