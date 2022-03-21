using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DG.DeInspektor.Attributes
{
	[AttributeUsage(AttributeTargets.Field)]
	public class DeHeaderAttribute : PropertyAttribute
	{
		public int marginTop;

		public int marginBottom;

		internal string text;

		internal string textColor;

		internal string bgColor;

		internal TextAnchor textAnchor;

		internal FontStyle fontStyle;

		internal int fontSize;

		public DeHeaderAttribute(string text, [Optional] string textColor, [Optional] string bgColor, FontStyle fontStyle = FontStyle.Bold, int fontSize = 11)
		{
		}
	}
}
