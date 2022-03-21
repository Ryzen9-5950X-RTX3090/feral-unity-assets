using System;

namespace ParadoxNotion.Design
{
	[AttributeUsage(AttributeTargets.Field)]
	public class ShowButtonAttribute : DrawerAttribute
	{
		public readonly string buttonTitle;

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

		public ShowButtonAttribute(string buttonTitle, string methodnameCallback)
		{
		}
	}
}
