using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class QuestCinder : ManagedBehaviour
{
	public Animator animator;

	public ActorBase actorBase;

	public Electric electricLeft;

	public Electric electricRight;

	public string attachPointLeft;

	public string attachPointRight;

	private Electric _electricLeft;

	private Electric _electricRight;

	private bool _electricHandsSetup;

	public float electricHandsStartDelay;

	public float electricHandsBetweenDelay;

	public override void MAwake()
	{
	}

	[IteratorStateMachine(typeof(<Init>d__9))]
	private IEnumerator Init()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<PlayElectricHandFX>d__13))]
	internal IEnumerator PlayElectricHandFX(bool inPlay)
	{
		return null;
	}
}
