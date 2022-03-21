using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace ThisOtherThing.UI.ShapeUtils
{
	public class Arcs
	{
		[Serializable]
		public class ArcProperties
		{
			public enum ArcDirection
			{
				Backward,
				Centered,
				Forward
			}

			public ArcDirection Direction;

			[Range(0f, 1f)]
			public float Length;

			private Vector3 endSegmentUnitPosition;

			private Vector3 startTangent;

			private Vector3 endTangent;

			private Vector3 centerNormal;

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

			public float AdjustedBaseAngle
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public float AdjustedDirection
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public float SegmentAngle
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public float EndSegmentAngle
			{
				[CompilerGenerated]
				get
				{
					return default(float);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public Vector3 EndSegmentUnitPosition
			{
				get
				{
					return default(Vector3);
				}
			}

			public Vector3 StartTangent
			{
				get
				{
					return default(Vector3);
				}
			}

			public Vector3 EndTangent
			{
				get
				{
					return default(Vector3);
				}
			}

			public Vector3 CenterNormal
			{
				get
				{
					return default(Vector3);
				}
			}

			public void UpdateAdjusted(int FullCircleResolution, float BaseAngle)
			{
			}
		}

		private static Vector3 tmpPosition;

		private static Vector2 tmpInnerRadius;

		private static Vector2 tmpOuterRadius;

		private static Vector2 tmpArcInnerRadius;

		private static Vector2 tmpArcOuterRadius;

		private static Vector3 tmpOffsetCenter;

		private static Vector3 noOverlapInnerOffset;

		private static Vector3 noOverlapOuterOffset;

		public static void AddSegment(ref VertexHelper vh, Vector2 center, Vector2 radius, Ellipses.EllipseProperties circleProperties, ArcProperties arcProperties, Color32 color, Vector2 uv, ref GeoUtils.UnitPositionData unitPositionData, GeoUtils.EdgeGradientData edgeGradientData)
		{
		}

		public static void AddArcRing(ref VertexHelper vh, Vector2 center, Vector2 radius, Ellipses.EllipseProperties ellipseProperties, ArcProperties arcProperties, GeoUtils.OutlineProperties outlineProperties, Color32 color, Vector2 uv, ref GeoUtils.UnitPositionData unitPositionData, GeoUtils.EdgeGradientData edgeGradientData)
		{
		}
	}
}
