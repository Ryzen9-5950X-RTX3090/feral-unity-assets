using System;

namespace ParadoxNotion.Design
{
	[AttributeUsage(AttributeTargets.Field)]
	public class MinValueAttribute : DrawerAttribute
	{
		public readonly float min;

		public override int priority
		{
			get
			{
				return default(int);
			}
		}

		public MinValueAttribute(float min)
		{
		}

		public MinValueAttribute(int min)
		{
		}
	}
}
