using System;

namespace ParadoxNotion.Design
{
	[AttributeUsage(AttributeTargets.Field)]
	public class CallbackAttribute : DrawerAttribute
	{
		public readonly string methodName;

		public override bool isDecorator
		{
			get
			{
				return default(bool);
			}
		}

		public override int priority
		{
			get
			{
				return default(int);
			}
		}

		public CallbackAttribute(string methodName)
		{
		}
	}
}
