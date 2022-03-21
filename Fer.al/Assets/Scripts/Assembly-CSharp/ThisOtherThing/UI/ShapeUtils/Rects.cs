using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

namespace ThisOtherThing.UI.ShapeUtils
{
	public class Rects
	{
		private static Vector3 tmpPos;

		private static Vector2 tmpUVPos;

		private static readonly Vector2[] defaultVertOffsets;

		public static void AddRect(ref VertexHelper vh, Vector2 center, float width, float height, Color32 color, Vector2 uv, bool flipUVX, bool flipUVY)
		{
		}

		public static void AddRect(ref VertexHelper vh, Vector2 center, float width, float height, Color32 color, GeoUtils.EdgeGradientData edgeGradientData, Vector2[] vertOffsets, bool flipUVX, bool flipUVY)
		{
		}

		public static void AddRectRing(ref VertexHelper vh, GeoUtils.OutlineProperties OutlineProperties, Vector2 center, float width, float height, Color32 color, Vector2 uv, GeoUtils.EdgeGradientData edgeGradientData, Vector2[] vertOffsets, bool flipUVX, bool flipUVY)
		{
		}

		public static void AddRectVertRing(ref VertexHelper vh, Vector2 center, float width, float height, Color32 color, float totalWidth, float totalHeight, bool addRingIndices = false, [Optional] Vector2[] vertOffsets, bool flipUVX = false, bool flipUVY = false)
		{
		}

		public static void AddRectQuadIndices(ref VertexHelper vh)
		{
		}

		public static void AddVerticalTwoColorRect(ref VertexHelper vh, Vector3 topLeft, float height, float width, Color32 topColor, Color32 bottomColor, Vector2 uv)
		{
		}

		public static void AddHorizontalTwoColorRect(ref VertexHelper vh, Vector3 topLeft, float height, float width, Color32 leftColor, Color32 rightColor, Vector2 uv)
		{
		}
	}
}
