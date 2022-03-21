using System;

namespace ParadoxNotion.Design
{
	[AttributeUsage(AttributeTargets.Field)]
	public class ShowIfAttribute : DrawerAttribute
	{
		public readonly string fieldName;

		public readonly int checkValue;

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

		public ShowIfAttribute(string fieldName, int checkValue)
		{
		}
	}
}
