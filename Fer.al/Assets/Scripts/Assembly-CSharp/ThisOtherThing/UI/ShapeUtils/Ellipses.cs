using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace ThisOtherThing.UI.ShapeUtils
{
	public class Ellipses
	{
		[Serializable]
		public class EllipseProperties
		{
			public enum EllipseFitting
			{
				Ellipse,
				UniformInner,
				UniformOuter
			}

			public enum ResolutionType
			{
				Calculated,
				Fixed
			}

			public EllipseFitting Fitting;

			public float BaseAngle;

			public ResolutionType Resolution;

			public int FixedResolution;

			public float ResolutionMaxDistance;

			public int AdjustedResolution
			{
				[CompilerGenerated]
				get
				{
					return default(int);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public void OnCheck()
			{
			}

			public void UpdateAdjusted(Vector2 radius, float offset)
			{
			}
		}

		private static Vector3 tmpVertPos;

		private static Vector2 tmpUVPos;

		private static Vector3 tmpInnerRadius;

		private static Vector3 tmpOuterRadius;

		public static void SetRadius(ref Vector2 radius, float width, float height, EllipseProperties properties)
		{
		}

		public static void AddCircle(ref VertexHelper vh, Vector2 center, Vector2 radius, EllipseProperties ellipseProperties, Color32 color, Vector2 uv, ref GeoUtils.UnitPositionData unitPositionData, GeoUtils.EdgeGradientData edgeGradientData)
		{
		}

		public static void AddRing(ref VertexHelper vh, Vector2 center, Vector2 radius, GeoUtils.OutlineProperties outlineProperties, EllipseProperties ellipseProperties, Color32 color, Vector2 uv, ref GeoUtils.UnitPositionData unitPositionData, GeoUtils.EdgeGradientData edgeGradientData)
		{
		}
	}
}
