using System.Text.RegularExpressions;
using UnityEngine;

namespace StrayTech.CustomAttributes
{
	public class RegexAttribute : PropertyAttribute
	{
		public enum Mode
		{
			Force,
			DisplayInvalid
		}

		public readonly string Pattern;

		public readonly Mode InputMode;

		public readonly RegexOptions MatchOptions;

		public RegexAttribute(string pattern, Mode inputMode = Mode.DisplayInvalid, RegexOptions matchOptions = RegexOptions.Singleline)
		{
		}
	}
}
