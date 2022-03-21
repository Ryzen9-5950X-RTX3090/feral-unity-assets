using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;

namespace ThisOtherThing.UI.ShapeUtils
{
	public class RoundedRects
	{
		public struct RoundedCornerUnitPositionData
		{
			public Vector2[] TLUnitPositions;

			public Vector2[] TRUnitPositions;

			public Vector2[] BRUnitPositions;

			public Vector2[] BLUnitPositions;
		}

		[Serializable]
		public class RoundedProperties
		{
			public enum RoundedType
			{
				None,
				Uniform,
				Individual
			}

			public enum ResolutionType
			{
				Uniform,
				Individual
			}

			public RoundedType Type;

			public ResolutionType ResolutionMode;

			public float UniformRadius;

			public bool UseMaxRadius;

			public float TLRadius;

			public GeoUtils.RoundingProperties TLResolution;

			public float TRRadius;

			public GeoUtils.RoundingProperties TRResolution;

			public float BRRadius;

			public GeoUtils.RoundingProperties BRResolution;

			public float BLRadius;

			public GeoUtils.RoundingProperties BLResolution;

			public GeoUtils.RoundingProperties UniformResolution;

			public float AdjustedTLRadius
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

			public float AdjustedTRRadius
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

			public float AdjustedBRRadius
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

			public float AdjustedBLRadius
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

			public void UpdateAdjusted(Rect rect, float offset)
			{
			}

			public void OnCheck(Rect rect)
			{
			}
		}

		private static Vector3 tmpV3;

		private static Vector3 tmpPos;

		private static Vector2 tmpUV;

		private static void SetCornerUnitPositions(RoundedProperties roundedProperties, ref RoundedCornerUnitPositionData cornerUnitPositions)
		{
		}

		private static void SetUnitPosition(ref Vector2[] unitPositions, int resolution, float baseAngle, bool makeSharpCorner)
		{
		}

		public static void AddRoundedRect(ref VertexHelper vh, Vector2 center, float width, float height, RoundedProperties roundedProperties, Color32 color, Vector2 uv, ref RoundedCornerUnitPositionData cornerUnitPositions, GeoUtils.EdgeGradientData edgeGradientData, Vector2[] vertOffsets, bool flipUVX, bool flipUVY)
		{
		}

		public static void AddRoundedRectLine(ref VertexHelper vh, Vector2 center, float width, float height, GeoUtils.OutlineProperties outlineProperties, RoundedProperties roundedProperties, Color32 color, Vector2 uv, ref RoundedCornerUnitPositionData cornerUnitPositions, GeoUtils.EdgeGradientData edgeGradientData, Vector2[] vertOffsets, bool flipUVX, bool flipUVY)
		{
		}

		private static void AddRoundedRectVerticesRing(ref VertexHelper vh, Vector2 center, float width, float height, float fullWidth, float fullHeight, float tlRadius, float tlOuterRadius, float trRadius, float trOuterRadius, float brRadius, float brOuterRadius, float blRadius, float blOuterRadius, RoundedCornerUnitPositionData cornerUnitPositions, Color32 color, Vector2 uv, bool addIndices, Vector2[] vertOffsets)
		{
		}

		private static void AddRoundedRingIndices(ref VertexHelper vh, RoundedCornerUnitPositionData cornerUnitPositions)
		{
		}
	}
}
