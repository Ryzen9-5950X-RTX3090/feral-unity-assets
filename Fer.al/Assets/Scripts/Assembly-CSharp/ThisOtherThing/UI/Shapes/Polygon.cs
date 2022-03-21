using ThisOtherThing.UI.ShapeUtils;
using UnityEngine;
using UnityEngine.UI;

namespace ThisOtherThing.UI.Shapes
{
	[AddComponentMenu("UI/Shapes/Polygon", 30)]
	public class Polygon : MaskableGraphic, IShape
	{
		public GeoUtils.ShapeProperties ShapeProperties;

		public PointsList.PointListsProperties PointListsProperties;

		public Polygons.PolygonProperties PolygonProperties;

		public GeoUtils.ShadowsProperties ShadowProperties;

		public GeoUtils.AntiAliasingProperties AntiAliasingProperties;

		private PointsList.PointsData[] pointsListData;

		private GeoUtils.EdgeGradientData edgeGradientData;

		private Rect pixelRect;

		public void ForceMeshUpdate()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnRectTransformDimensionsChange()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}
	}
}
