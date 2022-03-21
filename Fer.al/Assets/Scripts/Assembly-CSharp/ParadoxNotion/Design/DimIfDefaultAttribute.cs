using System;

namespace ParadoxNotion.Design
{
	[AttributeUsage(AttributeTargets.Field)]
	public class DimIfDefaultAttribute : DrawerAttribute
	{
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
	}
}
