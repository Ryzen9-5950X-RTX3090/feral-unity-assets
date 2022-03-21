using ThisOtherThing.UI.ShapeUtils;
using UnityEngine;
using UnityEngine.UI;

namespace ThisOtherThing.UI.Shapes
{
	[AddComponentMenu("UI/Shapes/Arc", 50)]
	public class Arc : MaskableGraphic, IShape
	{
		public GeoUtils.ShapeProperties ShapeProperties;

		public Ellipses.EllipseProperties EllipseProperties;

		public Arcs.ArcProperties ArcProperties;

		public Lines.LineProperties LineProperties;

		public PointsList.PointListProperties PointListProperties;

		private PointsList.PointsData PointsData;

		public GeoUtils.OutlineProperties OutlineProperties;

		public GeoUtils.ShadowsProperties ShadowProperties;

		public GeoUtils.AntiAliasingProperties AntiAliasingProperties;

		private GeoUtils.UnitPositionData unitPositionData;

		private GeoUtils.EdgeGradientData edgeGradientData;

		private Vector2 radius;

		protected override void OnEnable()
		{
		}

		public void ForceMeshUpdate()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}
	}
}
