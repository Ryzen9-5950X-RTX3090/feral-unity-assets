using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class QuestMudMonsterShot : MonoBehaviour
{
	public Transform visual;

	public GameObject mudSplatterHitPlayerFX;

	public GameObject mudSplatterHitGroundFX;

	public float speed;

	public float explodeShrinkTime;

	internal Vector3[] pointList;

	private QuestMudMonster _mover;

	private int _currentPointIndex;

	private bool _hit;

	internal QuestMudMonster mover
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	private void Update()
	{
	}

	[IteratorStateMachine(typeof(<Explode>d__13))]
	internal IEnumerator Explode(bool inHitPlayer, bool inForceToGround = true)
	{
		return null;
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	[IteratorStateMachine(typeof(<SpearHit>d__15))]
	internal IEnumerator SpearHit(QuestSpear inSpear)
	{
		return null;
	}
}
