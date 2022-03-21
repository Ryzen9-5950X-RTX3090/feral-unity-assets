using System;
using System.Collections.Generic;
using UnityEngine;

namespace ThisOtherThing.UI.ShapeUtils
{
	public class PointsList
	{
		[Serializable]
		public class PointListsProperties
		{
			public PointListProperties[] PointListProperties;
		}

		[Serializable]
		public class PointListProperties
		{
			public PointListGeneratorData GeneratorData;

			public Vector2[] Positions;

			[Range(0f, (float)Math.PI)]
			public float MaxAngle;

			[Min(0f)]
			public float RoundingDistance;

			public GeoUtils.RoundingProperties CornerRounding;

			public bool ShowHandles;

			public void SetPoints(RectTransform rectTransform)
			{
			}
		}

		[Serializable]
		public class PointListGeneratorData
		{
			public enum Generators
			{
				Custom,
				Rect,
				Round,
				RadialGraph,
				LineGraph,
				AngleLine,
				Star,
				Gear,
				SkewedQuad
			}

			[Serializable]
			public struct CornerPosition
			{
				public Vector2 position;

				public CornerAnchor anchor;

				public CornerPosition(Vector2 inPosition, CornerAnchor inAnchor)
				{
				}
			}

			public enum CornerAnchor
			{
				Center,
				TopLeft,
				TopRight,
				BottomRight,
				BottomLeft
			}

			public Generators Generator;

			public bool NeedsUpdate;

			public Vector2 Center;

			[Min(1f)]
			public float Width;

			[Min(1f)]
			public float Height;

			[Min(1f)]
			public float Radius;

			[Range(-1f, 1f)]
			public float Direction;

			public float[] FloatValues;

			public float MinFloatValue;

			public float MaxFloatValue;

			public int IntStartOffset;

			public float FloatStartOffset;

			public float Length;

			public float EndRadius;

			public int Resolution;

			public bool CenterPoint;

			public bool SkipLastPosition;

			public float Angle;

			public float InnerScaler;

			public float OuterScaler;

			public CornerPosition CornerA;

			public CornerPosition CornerB;

			public CornerPosition CornerC;

			public CornerPosition CornerD;
		}

		public struct PointsData
		{
			public bool NeedsUpdate;

			public bool IsClosed;

			public List<Vector2> Positions;

			public int NumPositions;

			public Vector2[] PositionTangents;

			public Vector2[] PositionNormals;

			public float TotalLength;

			public float[] PositionDistances;

			public float[] NormalizedPositionDistances;

			public Vector2 StartCapOffset;

			public Vector2 EndCapOffset;

			public bool GenerateRoundedCaps;

			public int RoundedCapResolution;

			public Vector2[] StartCapOffsets;

			public Vector2[] StartCapUVs;

			public Vector2[] EndCapOffsets;

			public Vector2[] EndCapUVs;

			public float LineWeight;
		}

		private static Vector2 tmpPos;

		private static Vector2 tmpBackV;

		private static Vector2 tmpBackNormV;

		private static Vector2 tmpForwV;

		private static Vector2 tmpForwNormV;

		private static Vector2 tmpBackPos;

		private static Vector2 tmpForwPos;

		private static List<Vector2> tmpCachedPositions;

		public static void SetPositions(PointListProperties pointListProperties, ref PointsData lineData)
		{
		}

		private static void CheckMinPointDistances(ref Vector2[] inPositions, ref List<Vector2> outPositions, float minDistance, bool isClosed)
		{
		}

		private static void InterpolatePoints(ref PointsData lineData, Vector2 prevPosition, Vector2 position, Vector2 nextPosition, PointListProperties pointListProperties, int index)
		{
		}

		private static void AddRoundedPoints(ref PointsData lineData, Vector2 backNormV, Vector2 position, Vector2 forwNormV, PointListProperties pointListProperties, float angle, float maxDistance)
		{
		}

		public static bool SetLineData(PointListProperties pointListProperties, ref PointsData lineData)
		{
			return default(bool);
		}

		private static void SetRoundedCapPointData(float centerAngle, ref Vector2[] offsets, ref Vector2[] uvs, int resolution, bool isStart)
		{
		}

		private static void SetPointData(Vector2 currentPoint, Vector2 nextPoint, ref Vector2 currentUnitTangent, ref Vector2 positionTangent, ref Vector2 positionNormal, ref Vector2 lastUnitTangent, ref float distance)
		{
		}
	}
}
