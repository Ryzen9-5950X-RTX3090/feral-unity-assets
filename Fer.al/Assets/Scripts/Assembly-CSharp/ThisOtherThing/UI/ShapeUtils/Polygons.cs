using System;
using UnityEngine;
using UnityEngine.UI;

namespace ThisOtherThing.UI.ShapeUtils
{
	public class Polygons
	{
		[Serializable]
		public class PolygonProperties
		{
			public enum CenterTypes
			{
				Calculated,
				Offset,
				CustomPosition,
				Cutout
			}

			public CenterTypes CenterType;

			public Vector2 CenterOffset;

			public Vector2 CustomCenter;

			[HideInInspector]
			public Vector2 AdjustedCenter;

			public CutoutProperties CutoutProperties;

			public void UpdateAdjusted(PointsList.PointListProperties pointListProperties)
			{
			}
		}

		[Serializable]
		public class CutoutProperties
		{
			[Min(3f)]
			public int Resolution;

			[Min(0f)]
			public float Radius;

			[Range(-3.141592f, 3.141592f)]
			public float RotationOffset;

			public GeoUtils.UnitPositionData UnitPositionData;
		}

		private static Vector3 tmpPos;

		public static void AddPolygon(ref VertexHelper vh, PolygonProperties polygonProperties, PointsList.PointListProperties pointListProperties, Vector2 positionOffset, Color32 color, Vector2 uv, ref PointsList.PointsData pointsData, GeoUtils.EdgeGradientData edgeGradientData, RectTransform rectTransform)
		{
		}
	}
}
