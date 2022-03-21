using System;
using UnityEngine;
using UnityEngine.UI;

namespace ThisOtherThing.UI.ShapeUtils
{
	public class Lines
	{
		[Serializable]
		public class LineProperties
		{
			public enum LineCapTypes
			{
				Close,
				Projected,
				Round
			}

			public LineCapTypes LineCap;

			public bool Closed;

			public GeoUtils.RoundingProperties RoundedCapResolution;

			public void OnCheck()
			{
			}
		}

		private static Vector3 tmpPos;

		private static Vector2 tmpPos2;

		public static void AddLine(ref VertexHelper vh, LineProperties lineProperties, PointsList.PointListProperties pointListProperties, Vector2 positionOffset, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, ref PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData, RectTransform rectTransform)
		{
		}

		public static void AddStartCap(ref VertexHelper vh, LineProperties lineProperties, Vector2 positionOffset, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, float uvXMin, float uvXLength, PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData)
		{
		}

		public static void AddEndCap(ref VertexHelper vh, LineProperties lineProperties, Vector2 positionOffset, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, float uvXMin, float uvXLength, PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData)
		{
		}

		public static void AddCloseCap(ref VertexHelper vh, bool isStart, int firstVertIndex, Vector2 position, Vector2 normal, Vector2 capOffset, int invertIndices, LineProperties lineProperties, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData, int currentVertCount)
		{
		}

		public static void AddProjectedCap(ref VertexHelper vh, bool isStart, int firstVertIndex, Vector2 position, Vector2 normal, Vector2 capOffset, int invertIndices, LineProperties lineProperties, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData, int currentVertCount)
		{
		}

		public static void AddRoundedCap(ref VertexHelper vh, bool isStart, int firstVertIndex, Vector2 position, Vector2 normal, Vector2 capOffset, int invertIndices, LineProperties lineProperties, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData, Vector2[] capOffsets, Vector2[] uvOffsets, float uvXMin, float uvXLength, int currentVertCount)
		{
		}
	}
}
