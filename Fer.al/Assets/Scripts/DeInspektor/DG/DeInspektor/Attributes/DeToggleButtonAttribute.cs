using System;
using System.Runtime.InteropServices;
using UnityEngine;

namespace DG.DeInspektor.Attributes
{
	[AttributeUsage(AttributeTargets.Field)]
	public class DeToggleButtonAttribute : PropertyAttribute
	{
		public string offText;

		internal string text;

		internal DePosition position;

		internal Color? bgOffColor;

		internal Color? bgOnColor;

		internal Color? labelOffColor;

		internal Color? labelOnColor;

		public DeToggleButtonAttribute(string text, DePosition position = DePosition.HExtended, [Optional] string bgOffColor, [Optional] string bgOnColor, [Optional] string labelOffColor, [Optional] string labelOnColor)
		{
		}
	}
}
