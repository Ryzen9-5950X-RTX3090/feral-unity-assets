using UnityEngine;
using UnityEngine.UI;

namespace ThisOtherThing.UI.Shapes
{
	[AddComponentMenu("UI/Shapes/Pixel Line", 100)]
	public class PixelLine : MaskableGraphic, IShape
	{
		public float LineWeight;

		public GeoUtils.SnappedPositionAndOrientationProperties SnappedProperties;

		private Vector3 center;

		public void ForceMeshUpdate()
		{
		}

		protected override void OnPopulateMesh(VertexHelper vh)
		{
		}
	}
}
