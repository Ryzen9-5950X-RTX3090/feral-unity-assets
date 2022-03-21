using System;
using UnityEngine;

namespace Lean.Common.Examples
{
	public class LeanGuide : ScriptableObject
	{
		public string LongName;

		public string ShortName;

		public TextAsset Documentation;

		[NonSerialized]
		private Texture2D icon;

		[NonSerialized]
		private string version;

		public Texture2D Icon
		{
			get
			{
				return null;
			}
		}

		public string Version
		{
			get
			{
				return null;
			}
		}
	}
}
