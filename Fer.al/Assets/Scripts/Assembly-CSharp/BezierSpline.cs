using UnityEngine;

public class BezierSpline : MonoBehaviour
{
	[SerializeField]
	private Vector3[] points;

	[SerializeField]
	private BezierControlPointMode[] modes;

	[SerializeField]
	private bool loop;

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

	public int ControlPointCount
	{
		get
		{
			return default(int);
		}
	}

	public int CurveCount
	{
		get
		{
			return default(int);
		}
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

	public Vector3 GetPoint(float t)
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

	public Vector3 FindClosest(Vector3 worldPoint, int numPoints, float threshold = -1f)
	{
		return default(Vector3);
	}

	public Vector3[] FindClosestGroup(Vector3 worldPoint, int numPoints, int groupSize, float gapSize, float threshold = -1f)
	{
		return null;
	}

	public void AddCurve()
	{
	}

	public void Reset()
	{
	}
}
