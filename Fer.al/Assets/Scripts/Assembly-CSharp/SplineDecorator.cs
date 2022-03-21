using UnityEngine;

public class SplineDecorator : MonoBehaviour
{
	public BezierSpline spline;

	public int frequency;

	public bool lookForward;

	public Transform[] items;

	private void Awake()
	{
	}
}
