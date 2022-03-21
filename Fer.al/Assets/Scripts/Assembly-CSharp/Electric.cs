using UnityEngine;

public class Electric : MonoBehaviour
{
	private LineRenderer lRend;

	public Transform transformPointA;

	public Transform transformPointB;

	public float UVVariation;

	private readonly int pointsCount;

	private readonly int half;

	private float randomness;

	private Vector3[] points;

	private readonly int pointIndexA;

	private readonly int pointIndexB;

	private readonly int pointIndexC;

	private readonly int pointIndexD;

	private readonly int pointIndexE;

	private readonly string mainTexture;

	private Vector2 mainTextureScale;

	private Vector2 mainTextureOffset;

	private float timer;

	private float timerTimeOut;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void CalculatePoints()
	{
	}

	private void SetRandomness()
	{
	}

	private Vector3 GetCenter(Vector3 a, Vector3 b)
	{
		return default(Vector3);
	}
}
