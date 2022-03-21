using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class FourCrowsCrow : MonoBehaviour
{
	public FCCrowIdle fCCrowIdle;

	public GameObject crowGeometry;

	public ParticleSystem appearEffect;

	public ParticleSystem disappearEffect;

	private void Awake()
	{
	}

	internal void ShowCrow(bool inShow, bool inPlayFX)
	{
	}

	[IteratorStateMachine(typeof(<LoseGame>d__6))]
	internal IEnumerator LoseGame()
	{
		return null;
	}

	internal void ResetCrow()
	{
	}
}
