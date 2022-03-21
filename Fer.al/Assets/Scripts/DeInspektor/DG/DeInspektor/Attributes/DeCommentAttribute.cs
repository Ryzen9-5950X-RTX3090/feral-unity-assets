using System;
using UnityEngine;

namespace DG.DeInspektor.Attributes
{
	[AttributeUsage(AttributeTargets.Field)]
	public class DeCommentAttribute : PropertyAttribute
	{
		public int fontSize;

		public int marginBottom;

		public TextAnchor textAnchor;

		internal string text;

		internal DeCondition condition;

		internal ConditionalBehaviour behaviour;

		public DeCommentAttribute(string text, int marginBottom = 3)
		{
		}

		public DeCommentAttribute(string text, string propertyToCompare, int value, Condition conditionType = Condition.Is, ConditionalBehaviour behaviour = ConditionalBehaviour.Hide)
		{
		}
	}
}
