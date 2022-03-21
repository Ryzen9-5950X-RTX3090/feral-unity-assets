using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[ManagedBehaviourManager("SanctuaryManager")]
public class SanctuaryTwiggleWorker : SanctuaryTwiggle
{
	[SerializeField]
	private GameObject _fxAppearPrefab;

	[SerializeField]
	private GameObject _fxTeleportPrefab;

	[SerializeField]
	private float _minTime;

	[SerializeField]
	private float _maxTime;

	private float _timer;

	[SerializeField]
	private Color _gizmoColor;

	private List<GameObject> _twigglePerchPoints;

	private int _lastPositionIndex;

	private bool _initialized;

	[IteratorStateMachine(typeof(<InitWait>d__9))]
	protected override IEnumerator InitWait()
	{
		return null;
	}

	public override void MUpdate()
	{
	}

	private void SetTwigglePerchPoint()
	{
	}

	private int GetRandomPerchPoint()
	{
		return default(int);
	}

	private void SpawnAppearFx()
	{
	}

	private void SpawnMoveFx()
	{
	}

	[IteratorStateMachine(typeof(<SetTwiggleActive>d__15))]
	private IEnumerator SetTwiggleActive()
	{
		return null;
	}

	private void SetRandomTime()
	{
	}

	private void OnDrawGizmos()
	{
	}
}
