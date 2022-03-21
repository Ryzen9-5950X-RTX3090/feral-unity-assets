using System;
using System.Runtime.InteropServices;

namespace DG.DeInspektor.Attributes
{
	[AttributeUsage(AttributeTargets.Method)]
	public class DeMethodButtonAttribute : Attribute
	{
		internal string text;

		internal int order;

		internal object[] parameters;

		public DeMethodButtonAttribute([Optional] string buttonText, int order = 0, object[] parameters)
		{
		}
	}
}
