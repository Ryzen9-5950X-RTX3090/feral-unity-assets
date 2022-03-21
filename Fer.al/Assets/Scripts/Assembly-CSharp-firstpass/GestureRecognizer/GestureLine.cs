using System;
using System.Collections.Generic;
using UnityEngine;

namespace GestureRecognizer
{
	[Serializable]
	public class GestureLine
	{
		public List<Vector2> points;

		public bool closedLine;
	}
}
