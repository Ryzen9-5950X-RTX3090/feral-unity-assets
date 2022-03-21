using System;
using UnityEngine;

namespace DG.DeInspektor.Attributes
{
	[AttributeUsage(AttributeTargets.Field)]
	public class DeDisabledAttribute : PropertyAttribute
	{
		internal DeCondition condition;

		public DeDisabledAttribute(string propertyToCompare, bool value)
		{
		}

		public DeDisabledAttribute(string propertyToCompare, Condition conditionType = Condition.IsNullOrEmpty)
		{
		}
	}
}
