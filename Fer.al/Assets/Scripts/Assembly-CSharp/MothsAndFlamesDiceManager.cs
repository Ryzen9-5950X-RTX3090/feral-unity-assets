using System.Collections;
using System.Runtime.CompilerServices;

public class MothsAndFlamesDiceManager : MonoBehaviour
{
	public MothsAndFlamesDice[] allDice;

	internal int numDiceRolling;

	private MothsAndFlamesGame _game;

	internal void Init()
	{
	}

	internal void RequestRollValues()
	{
	}

	internal void ReceiveRollValues(string inRollResults)
	{
	}

	private void ResultCheck(MothsAndFlamesDice.EDiceFaceValue inFaceValue, ref int refM, ref int refF)
	{
	}

	internal MothsAndFlamesGame.EBetTypes GetResults()
	{
		return default(MothsAndFlamesGame.EBetTypes);
	}

	[IteratorStateMachine(typeof(<StartShake>d__8))]
	internal IEnumerator StartShake()
	{
		return null;
	}

	internal void Unload()
	{
	}
}
