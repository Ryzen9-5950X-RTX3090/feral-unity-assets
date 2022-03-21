using UnityEngine;

namespace StrayTech.CustomAttributes
{
	public class ButtonAttribute : PropertyAttribute
	{
		public readonly string ButtonLabel;

		public readonly string ButtonText;

		public ButtonAttribute(string buttonText, string buttonLabel)
		{
		}

		public ButtonAttribute(string buttonText)
		{
		}

		public ButtonAttribute()
		{
		}
	}
}
