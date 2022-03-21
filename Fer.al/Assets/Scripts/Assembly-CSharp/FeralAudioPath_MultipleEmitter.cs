using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BezierSpline))]
public class FeralAudioPath_MultipleEmitter : ManagedBehaviour
{
	private BezierSpline spline;

	private FeralAudioEmitter emitter;

	private Vector3 playerPosition;

	private List<FeralAudioEmitter> secondaryEmitters;

	public int secondaryEmitterCount;

	public float emitterGap;

	public int updateInterval;

	public int pointCount;

	public float threshold;

	private int updateCount;

	private float skipDistance;

	private Vector3 previousPlayerPos;

	public override void MStart()
	{
	}

	public override void MUpdate()
	{
	}

	private void UpdateEmitterPosition()
	{
	}
}
