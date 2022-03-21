using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DG.DeInspektor.Attributes
{
	[AttributeUsage(AttributeTargets.Field)]
	public class DeRangeAttribute : PropertyAttribute
	{
		internal float min;

		internal float max;

		internal string label;

		public DeRangeAttribute(float min, float max, [Optional] string label)
		{
		}
	}
}
