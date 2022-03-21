using System;

namespace ParadoxNotion.Design
{
	[AttributeUsage(AttributeTargets.Field)]
	public abstract class DrawerAttribute : Attribute
	{
		public virtual int priority
		{
			get
			{
				return default(int);
			}
		}

		public virtual bool isDecorator
		{
			get
			{
				return default(bool);
			}
		}
	}
}
