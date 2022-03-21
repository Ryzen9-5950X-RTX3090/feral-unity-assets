using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.AI;

public class MinimapBlipMainQuestNavIndicator : ManagedBehaviour
{
	public bool showDebugIndicatorPath;

	public float checkTime;

	public float indicatorBlendSpeed;

	private float _checkTime;

	private float _indicatorScaler;

	private Vector3 _indicatorPosition;

	private Vector3 _indicatorOldPosition;

	private Vector3 _indicatorNewPosition;

	private NavMeshPath indicatorPath;

	private Coroutine MakePathCoroutine;

	public override void MAwake()
	{
	}

	internal Vector3 GetIndicatorPosition()
	{
		return default(Vector3);
	}

	[IteratorStateMachine(typeof(<MakePath>d__12))]
	private IEnumerator MakePath()
	{
		return null;
	}

	private void OnDrawGizmos()
	{
	}
}
