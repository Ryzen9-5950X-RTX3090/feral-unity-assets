using ThisOtherThing.UI.ShapeUtils;
using UnityEngine;
using UnityEngine.UI;

namespace ThisOtherThing.UI.Shapes
{
	[AddComponentMenu("UI/Shapes/Sector", 50)]
	public class Sector : MaskableGraphic, IShape
	{
		public GeoUtils.ShapeProperties ShapeProperties;

		public Ellipses.EllipseProperties EllipseProperties;

		public Arcs.ArcProperties ArcProperties;

		public GeoUtils.ShadowsProperties ShadowProperties;

		public GeoUtils.AntiAliasingProperties AntiAliasingProperties;

		private GeoUtils.UnitPositionData unitPositionData;

		private GeoUtils.EdgeGradientData edgeGradientData;

		private Vector2 radius;

		private Rect pixelRect;

		public void ForceMeshUpdate()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}
	}
}
