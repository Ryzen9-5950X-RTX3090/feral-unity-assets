using System;
using UnityEngine;

namespace Cinemachine
{
	public abstract class CinemachinePathBase : MonoBehaviour
	{
		[Serializable]
		[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
		public class Appearance
		{
			[Tooltip("The color of the path itself when it is active in the editor")]
			public Color pathColor;

			[Tooltip("The color of the path itself when it is inactive in the editor")]
			public Color inactivePathColor;

			[Range(0f, 10f)]
			[Tooltip("The width of the railroad-tracks that are drawn to represent the path")]
			public float width;
		}

		public enum PositionUnits
		{
			PathUnits,
			Distance,
			Normalized
		}

		[Tooltip("Path samples per waypoint.  This is used for calculating path distances.")]
		[Range(1f, 100f)]
		public int m_Resolution;

		[Tooltip("The settings that control how the path will appear in the editor scene view.")]
		public Appearance m_Appearance;

		private float[] m_DistanceToPos;

		private float[] m_PosToDistance;

		private int m_CachedSampleSteps;

		private float m_PathLength;

		private float m_cachedPosStepSize;

		private float m_cachedDistanceStepSize;

		public abstract float MinPos { get; }

		public abstract float MaxPos { get; }

		public abstract bool Looped { get; }

		public abstract int DistanceCacheSampleStepsPerSegment { get; }

		public float PathLength
		{
			get
			{
				return default(float);
			}
		}

		public virtual float StandardizePos(float pos)
		{
			return default(float);
		}

		public abstract Vector3 EvaluatePosition(float pos);

		public abstract Vector3 EvaluateTangent(float pos);

		public abstract Quaternion EvaluateOrientation(float pos);

		public virtual float FindClosestPoint(Vector3 p, int startSegment, int searchRadius, int stepsPerSegment)
		{
			return default(float);
		}

		public float MinUnit(PositionUnits units)
		{
			return default(float);
		}

		public float MaxUnit(PositionUnits units)
		{
			return default(float);
		}

		public virtual float StandardizeUnit(float pos, PositionUnits units)
		{
			return default(float);
		}

		public Vector3 EvaluatePositionAtUnit(float pos, PositionUnits units)
		{
			return default(Vector3);
		}

		public Vector3 EvaluateTangentAtUnit(float pos, PositionUnits units)
		{
			return default(Vector3);
		}

		public Quaternion EvaluateOrientationAtUnit(float pos, PositionUnits units)
		{
			return default(Quaternion);
		}

		public virtual void InvalidateDistanceCache()
		{
		}

		public bool DistanceCacheIsValid()
		{
			return default(bool);
		}

		public float StandardizePathDistance(float distance)
		{
			return default(float);
		}

		public float ToNativePathUnits(float pos, PositionUnits units)
		{
			return default(float);
		}

		public float FromPathNativeUnits(float pos, PositionUnits units)
		{
			return default(float);
		}

		private void ResamplePath(int stepsPerSegment)
		{
		}
	}
}
