using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class AltUnityInputsVisualiser : UnityEngine.MonoBehaviour
{
	public float VisibleTime;

	[Space]
	[SerializeField]
	private AltUnityInputMark Template;

	private readonly List<AltUnityInputMark> _pool;

	private readonly Dictionary<int, AltUnityInputMark> _continuously;

	private Transform _transform;

	private float currentRatio;

	private float initialRatio;

	public float growthBound;

	public float approachSpeed;

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(<VisualizerPulse>d__10))]
	private IEnumerator VisualizerPulse(AltUnityInputMark mark)
	{
		return null;
	}

	public void ShowClick(Vector2 pos)
	{
	}

	public int ShowContinuousInput(Vector2 pos, int id)
	{
		return default(int);
	}

	private AltUnityInputMark GetMark()
	{
		return null;
	}

	private void PutMark(AltUnityInputMark mark)
	{
	}
}
