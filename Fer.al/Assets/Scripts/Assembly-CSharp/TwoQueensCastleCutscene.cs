using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class TwoQueensCastleCutscene : Cutscene
{
	[SerializeField]
	private Vector3 _cameraFirstShotPosition;

	[SerializeField]
	private Vector3 _cameraFirstShotRotation;

	[SerializeField]
	private Vector3 _playerEndPoint;

	private bool _isPlayerAtTarget;

	protected override void PrePlay()
	{
	}

	[IteratorStateMachine(typeof(<Play>d__5))]
	protected override IEnumerator Play()
	{
		return null;
	}
}
