using ThisOtherThing.UI.ShapeUtils;
using UnityEngine;
using UnityEngine.UI;

namespace ThisOtherThing.UI.Shapes
{
	[AddComponentMenu("UI/Shapes/Ellipse", 1)]
	public class Ellipse : MaskableGraphic, IShape
	{
		public GeoUtils.OutlineShapeProperties ShapeProperties;

		public Ellipses.EllipseProperties EllipseProperties;

		public GeoUtils.OutlineProperties OutlineProperties;

		public GeoUtils.ShadowsProperties ShadowProperties;

		public GeoUtils.AntiAliasingProperties AntiAliasingProperties;

		public Sprite Sprite;

		private GeoUtils.UnitPositionData unitPositionData;

		private GeoUtils.EdgeGradientData edgeGradientData;

		private Vector2 radius;

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
