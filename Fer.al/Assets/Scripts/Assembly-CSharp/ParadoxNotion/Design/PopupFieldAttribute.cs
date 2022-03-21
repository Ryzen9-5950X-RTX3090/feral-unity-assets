using System;

namespace ParadoxNotion.Design
{
	[AttributeUsage(AttributeTargets.Field)]
	public class PopupFieldAttribute : DrawerAttribute
	{
		public readonly object[] options;

		public PopupFieldAttribute(object[] options)
		{
		}
	}
}
