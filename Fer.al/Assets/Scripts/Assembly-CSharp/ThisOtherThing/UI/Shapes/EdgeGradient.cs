using System;
using UnityEngine;
using UnityEngine.UI;

namespace ThisOtherThing.UI.Shapes
{
	[AddComponentMenu("UI/Shapes/Edge Gradient", 100)]
	public class EdgeGradient : MaskableGraphic, IShape
	{
		public enum Positions
		{
			Top,
			Bottom,
			Left,
			Right,
			OuterTop,
			OuterBottom,
			OuterLeft,
			OuterRight
		}

		[Serializable]
		public class GradientProperty
		{
			public float Size;

			public Color32 Color;

			public Positions Position;
		}

		public GradientProperty[] Properties;

		private Vector3 topLeft;

		private Color32 gradientColor;

		public void ForceMeshUpdate()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}
	}
}
