using System;

namespace DG.DeInspektor.Attributes
{
	[AttributeUsage(AttributeTargets.Class)]
	public class DeComponentDescriptionAttribute : Attribute
	{
		internal string text;

		public DeComponentDescriptionAttribute(string text)
		{
		}
	}
}
