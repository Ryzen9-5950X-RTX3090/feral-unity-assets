using System;
using UnityEngine;

namespace DG.DeInspektor.Attributes
{
	[AttributeUsage(AttributeTargets.Field)]
	public class DeConditionalAttribute : PropertyAttribute
	{
		internal DeCondition condition;

		internal ConditionalBehaviour behaviour;

		public DeConditionalAttribute(string propertyToCompare, bool value, ConditionalBehaviour behaviour = ConditionalBehaviour.Disable)
		{
		}
	}
}
