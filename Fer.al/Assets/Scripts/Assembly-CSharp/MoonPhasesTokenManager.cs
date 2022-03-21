using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MoonPhasesTokenManager : MonoBehaviour
{
	public float maxMoveTime;

	public float minMoveTime;

	internal float moveTime;

	public Transform playerToken;

	public Transform dealerToken;

	public Transform playerStart;

	public Transform dealerStart;

	public Transform[] crescentLocations;

	public Transform[] gibbousLocations;

	public Transform[] fullLocations;

	public Transform[] playerTokenLocations;

	public Transform[] dealerTokenLocations;

	private MoonPhasesGame _game;

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(<MoveTokens>d__14))]
	internal IEnumerator MoveTokens()
	{
		return null;
	}

	private Vector3[] GetPositions(MoonPhasesGame.Player inPlayer, Transform[] inTrans, bool inIsPlayer)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<MoveToken>d__16))]
	private IEnumerator MoveToken(Transform inTrans, Vector3[] inEndPos)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<ResetTokens>d__17))]
	internal IEnumerator ResetTokens(bool inImmediate)
	{
		return null;
	}
}
