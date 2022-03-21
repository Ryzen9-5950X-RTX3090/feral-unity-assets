using System;
using UnityEngine;

namespace DG.DeInspektor.Attributes
{
	[AttributeUsage(AttributeTargets.Field)]
	public class DeBeginDisabledAttribute : PropertyAttribute
	{
		internal DeCondition condition;

		public DeBeginDisabledAttribute(string propertyToCompare, bool value)
		{
		}

		public DeBeginDisabledAttribute(string propertyToCompare, int value, Condition conditionType = Condition.Is)
		{
		}
	}
}
