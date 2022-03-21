using System;
using System.Collections.Generic;
using UnityEngine;

namespace GestureRecognizer
{
	[CreateAssetMenu]
	public class GesturePattern : ScriptableObject
	{
		public string id;

		[Obsolete]
		[HideInInspector]
		[SerializeField]
		public List<Vector2> points;

		public GestureData gesture;

		public bool useLinesOrder;

		public bool useLinesDirections;
	}
}
