using System;
using ThisOtherThing.UI.ShapeUtils;
using UnityEngine;
using UnityEngine.UI;

namespace ThisOtherThing.UI.Shapes
{
	[AddComponentMenu("UI/Shapes/Rectangle", 1)]
	public class Rectangle : MaskableGraphic, IShape
	{
		public bool flipX;

		public bool flipY;

		public Vector2[] cornerOffsets;

		public GeoUtils.OutlineShapeProperties ShapeProperties;

		public RoundedRects.RoundedProperties RoundedProperties;

		public GeoUtils.OutlineProperties OutlineProperties;

		public GeoUtils.ShadowsProperties ShadowProperties;

		public GeoUtils.AntiAliasingProperties AntiAliasingProperties;

		[SerializeField]
		private Sprite _sprite;

		private RoundedRects.RoundedCornerUnitPositionData unitPositionData;

		private GeoUtils.EdgeGradientData edgeGradientData;

		public Action OnCornersChanged;

		public Sprite Sprite
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override Texture mainTexture
		{
			get
			{
				return null;
			}
		}

		public void ForceMeshUpdate()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}

		protected override void UpdateMaterial()
		{
		}
	}
}
