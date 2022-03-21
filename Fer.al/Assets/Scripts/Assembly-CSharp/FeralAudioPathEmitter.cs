using UnityEngine;

[ManagedBehaviourManager("FeralAudioManager")]
[RequireComponent(typeof(BezierSpline))]
public class FeralAudioPathEmitter : ManagedBehaviour
{
	private BezierSpline _bezierSpline;

	private FeralAudioEmitter _feralAudioEmitter;

	private Vector3 _playerPosition;

	public int updateInterval;

	public int pointCount;

	public float threshold;

	private int _updateCount;

	private float _skipDistance;

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
