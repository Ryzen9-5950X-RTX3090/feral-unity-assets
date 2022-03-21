using System;
using UnityEngine;

namespace DG.DeInspektor.Attributes
{
	[AttributeUsage(AttributeTargets.Field)]
	public class DeButtonAttribute : PropertyAttribute
	{
		internal Type targetType;

		internal string text;

		internal string methodName;

		internal object[] parameters;

		internal DePosition position;

		public DeButtonAttribute(string buttonText, Type targetType, string methodName, object[] parameters)
		{
		}
	}
}
