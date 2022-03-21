using System;

namespace Server
{
	[AttributeUsage(AttributeTargets.Method)]
	public class FakeMessageRouteAttribute : MessageRouteAttribute
	{
		public FakeMessageRouteAttribute(XtCmd cmd)
		{
		}
	}
}
