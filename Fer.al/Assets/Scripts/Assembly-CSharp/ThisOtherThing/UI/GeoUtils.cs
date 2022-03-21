using System;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace ThisOtherThing.UI
{
	public class GeoUtils
	{
		[Serializable]
		public class ShapeProperties
		{
			public Color32 FillColor;
		}

		[Serializable]
		public class OutlineShapeProperties : ShapeProperties
		{
			public bool DrawFill;

			public bool DrawFillShadow;

			public bool DrawOutline;

			public Color32 OutlineColor;

			public bool DrawOutlineShadow;
		}

		[Serializable]
		public class AntiAliasingProperties
		{
			public float AntiAliasing;

			public float Adjusted
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

			public void UpdateAdjusted(Canvas canvas)
			{
			}

			public void OnCheck()
			{
			}
		}

		[Serializable]
		public class RoundingProperties
		{
			public enum ResolutionType
			{
				Calculated,
				Fixed
			}

			public ResolutionType Resolution;

			public int FixedResolution;

			[Min(0.01f)]
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

			public bool MakeSharpCorner
			{
				[CompilerGenerated]
				get
				{
					return default(bool);
				}
				[CompilerGenerated]
				private set
				{
				}
			}

			public void OnCheck(int minFixedResolution = 2)
			{
			}

			public void UpdateAdjusted(float radius, float offset, float numCorners)
			{
			}

			public void UpdateAdjusted(float radius, float offset, RoundingProperties overrideProperties, float numCorners)
			{
			}
		}

		[Serializable]
		public class OutlineProperties
		{
			public enum LineType
			{
				Inner,
				Center,
				Outer
			}

			public LineType Type;

			public float LineWeight;

			public float HalfLineWeight
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

			public float GetOuterDistace()
			{
				return default(float);
			}

			public float GetCenterDistace()
			{
				return default(float);
			}

			public float GetInnerDistace()
			{
				return default(float);
			}

			public void OnCheck()
			{
			}

			public void UpdateAdjusted()
			{
			}
		}

		[Serializable]
		public class ShadowsProperties
		{
			public bool ShowShape;

			public bool ShowShadows;

			[Range(-1f, 1f)]
			public float Angle;

			[Min(0f)]
			public float Distance;

			public ShadowProperties[] Shadows;

			[HideInInspector]
			public Vector2 Offset;

			public bool ShadowsEnabled
			{
				get
				{
					return default(bool);
				}
			}

			public void UpdateAdjusted()
			{
			}

			public Vector2 GetCenterOffset(Vector2 center, int index)
			{
				return default(Vector2);
			}
		}

		[Serializable]
		public class ShadowProperties
		{
			public Color32 Color;

			public Vector2 Offset;

			[Min(0f)]
			public float Size;

			[Range(0f, 1f)]
			public float Softness;
		}

		public struct EdgeGradientData
		{
			public bool IsActive;

			public float InnerScale;

			public float ShadowOffset;

			public float SizeAdd;

			public void SetActiveData(float innerScale, float shadowOffset, float sizeAdd)
			{
			}

			public void Reset()
			{
			}
		}

		[Serializable]
		public class SnappedPositionAndOrientationProperties
		{
			public enum OrientationTypes
			{
				Horizontal,
				Vertical
			}

			public enum PositionTypes
			{
				Center,
				Top,
				Bottom,
				Left,
				Right
			}

			public OrientationTypes Orientation;

			public PositionTypes Position;
		}

		public struct UnitPositionData
		{
			public Vector3[] UnitPositions;

			public float LastBaseAngle;

			public float LastDirection;
		}

		public static readonly Vector3 UpV3;

		public static readonly Vector3 DownV3;

		public static readonly Vector3 LeftV3;

		public static readonly Vector3 RightV3;

		public static readonly Vector3 ZeroV3;

		public static readonly Vector2 ZeroV2;

		public static readonly Vector3 UINormal;

		public static readonly Vector4 UITangent;

		public static readonly float HalfPI;

		public static readonly float TwoPI;

		public static float GetAdjustedAntiAliasing(Canvas canvas, float antiAliasing)
		{
			return default(float);
		}

		public static void AddOffset(ref float width, ref float height, float offset)
		{
		}

		public static void SetUnitPositionData(ref UnitPositionData unitPositionData, int resolution, float baseAngle = 0f, float direction = 1f)
		{
		}

		public static void SetUnitPositions(ref Vector2[] positions, int resolution, float angleOffset = 0f, float radius = 1f)
		{
		}

		public static float RadianAngleDifference(float angle1, float angle2)
		{
			return default(float);
		}

		public static int SimpleMap(int x, int in_max, int out_max)
		{
			return default(int);
		}

		public static float SimpleMap(float x, float in_max, float out_max)
		{
			return default(float);
		}

		public static float Map(float x, float in_min, float in_max, float out_min, float out_max)
		{
			return default(float);
		}
	}
}
