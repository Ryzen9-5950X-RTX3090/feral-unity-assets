using UnityEngine;

public class FeralAudioMultiPathEmitter : ManagedBehaviour
{
	private BezierSpline[] splines;

	private FeralAudioEmitter emitter;

	private Vector3 playerPosition;

	public int updateInterval;

	public int pointCount;

	public float threshold;

	private int updateCount;

	private float skipDistance;

	public bool DebugPath;

	public GameObject DebugPathMarkerPrefab;

	public GameObject DebugEmitterMarkerPrefab;

	private GameObject DebugEmitterMarker;

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

	private void DrawDebugPath()
	{
	}
}
