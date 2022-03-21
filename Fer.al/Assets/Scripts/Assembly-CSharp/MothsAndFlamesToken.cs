using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class MothsAndFlamesToken : MonoBehaviour
{
	public float moveTime;

	public GameObject crystalGlowBlueFX;

	public GameObject crystalGlowOrangeFX;

	internal MothsAndFlamesBetSpot betSpot;

	private Coroutine MoveTokenCoroutine;

	internal void BetSpotSelected(Vector3 inEndPosition, bool inPlayPlacedAudio, bool inPlayPickupAudio)
	{
	}

	[IteratorStateMachine(typeof(<MoveToken>d__6))]
	private IEnumerator MoveToken(Vector3 inEndPosition, bool inPlayPlacedAudio)
	{
		return null;
	}

	internal void Unload(Vector3 inPosition)
	{
	}
}
