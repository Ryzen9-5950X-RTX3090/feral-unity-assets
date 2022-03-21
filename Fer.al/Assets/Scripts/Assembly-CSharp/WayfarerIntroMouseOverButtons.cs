using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WayfarerIntroMouseOverButtons : MonoBehaviour
{
	public Transform objectToGrow;

	public float growTime;

	public float sizeMultiplier;

	public Interpolation.InterpolationType interpolationType;

	private bool growing;

	private bool returningToNormal;

	private float elapsedTime;

	private Vector3 startingScale;

	private void Awake()
	{
	}

	public void Grow()
	{
	}

	[IteratorStateMachine(typeof(<GrowCoroutine>d__10))]
	private IEnumerator GrowCoroutine()
	{
		return null;
	}

	public void ReturnToNormal()
	{
	}

	[IteratorStateMachine(typeof(<ReturnToNormalCoroutine>d__12))]
	private IEnumerator ReturnToNormalCoroutine()
	{
		return null;
	}
}
