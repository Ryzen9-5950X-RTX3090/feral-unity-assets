using ThisOtherThing.UI.ShapeUtils;
using UnityEngine;
using UnityEngine.UI;

namespace ThisOtherThing.UI.Shapes
{
	[AddComponentMenu("UI/Shapes/Line", 30)]
	public class Line : MaskableGraphic, IShape
	{
		public GeoUtils.ShapeProperties ShapeProperties;

		public PointsList.PointListsProperties PointListsProperties;

		public Lines.LineProperties LineProperties;

		public GeoUtils.OutlineProperties OutlineProperties;

		public GeoUtils.ShadowsProperties ShadowProperties;

		public GeoUtils.AntiAliasingProperties AntiAliasingProperties;

		public Sprite Sprite;

		private PointsList.PointsData[] pointsListData;

		private GeoUtils.EdgeGradientData edgeGradientData;

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
