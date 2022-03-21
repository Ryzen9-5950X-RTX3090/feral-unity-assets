using System;
using UnityEngine;

namespace NodeCanvas.Framework
{
	[Serializable]
	public class CanvasGroup
	{
		public string name;

		public Rect rect;

		public Color color;

		public bool autoGroup;

		public CanvasGroup()
		{
		}

		public CanvasGroup(Rect rect, string name)
		{
		}
	}
}
