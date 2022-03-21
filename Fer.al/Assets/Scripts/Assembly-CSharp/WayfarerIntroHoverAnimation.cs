using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WayfarerIntroHoverAnimation : MonoBehaviour
{
	public float translateTime;

	public float translateDistance;

	public float rotateTime;

	public float shrinkTime;

	private Vector3 startingPosition;

	private Vector3 startingRotation;

	private float elapsedTranslateTime;

	private float elapsedRotateTime;

	private float elapsedShrinkTime;

	private void Awake()
	{
	}

	private void Update()
	{
	}

	private void UpdateTime()
	{
	}

	public void Shrink()
	{
	}

	[IteratorStateMachine(typeof(<ShrinkCoroutine>d__13))]
	private IEnumerator ShrinkCoroutine()
	{
		return null;
	}
}
