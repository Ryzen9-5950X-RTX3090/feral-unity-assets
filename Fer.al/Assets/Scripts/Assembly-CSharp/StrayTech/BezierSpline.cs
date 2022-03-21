using UnityEngine;

namespace StrayTech
{
	public class BezierSpline : MonoBehaviour
	{
		public enum BezierControlPointMode
		{
			Free,
			Aligned,
			Mirrored
		}

		[SerializeField]
		private Vector3[] _points;

		[SerializeField]
		private BezierControlPointMode[] _modes;

		[SerializeField]
		private bool _loop;

		[SerializeField]
		private int _interpolationAccuracy;

		private float _length;

		public bool Loop
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float Length
		{
			get
			{
				return default(float);
			}
		}

		public int CurveCount
		{
			get
			{
				return default(int);
			}
		}

		public int ControlPointCount
		{
			get
			{
				return default(int);
			}
		}

		private void Awake()
		{
		}

		public Vector3 GetControlPoint(int index)
		{
			return default(Vector3);
		}

		public void SetControlPoint(int index, Vector3 point)
		{
		}

		public BezierControlPointMode GetControlPointMode(int index)
		{
			return default(BezierControlPointMode);
		}

		public void SetControlPointMode(int index, BezierControlPointMode mode)
		{
		}

		private void EnforceMode(int index)
		{
		}

		public Vector3 GetPosition(float t)
		{
			return default(Vector3);
		}

		public Vector3 GetVelocity(float t)
		{
			return default(Vector3);
		}

		public Vector3 GetDirection(float t)
		{
			return default(Vector3);
		}

		public void AddCurve()
		{
		}

		public float GetClosestPointParam(Vector3 point, int iterations, float start = 0f, float end = 1f, float step = 0.01f)
		{
			return default(float);
		}

		private float GetClosestPointParamOnSegmentIntern(Vector3 point, float start, float end, float step)
		{
			return default(float);
		}

		private void CalculateSplineLength()
		{
		}

		public void Reset()
		{
		}
	}
}
