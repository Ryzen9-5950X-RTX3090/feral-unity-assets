using System;
using UnityEngine;

namespace DG.DemiLib
{
	[Serializable]
	public class DeColorPalette
	{
		public DeColorGlobal global;

		public DeColorBG bg;

		public DeColorContent content;

		public static Color HexToColor(string hex)
		{
			return default(Color);
		}

		private static int HexToInt(char hexVal)
		{
			return default(int);
		}
	}
}
