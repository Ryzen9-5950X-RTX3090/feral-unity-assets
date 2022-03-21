using System.Collections.Generic;
using UnityEngine;

public class FeralAnimationEvent : ManagedBehaviour
{
	private static string _feralAnimationEventInitializedVar;

	private Animator _animator;

	private List<FeralAnimationEvents.EventInfo> _killEventsOnExit;

	public static string feralAnimationEventInitializedVar
	{
		get
		{
			return null;
		}
	}

	public override void MOnEnable()
	{
	}

	private bool HasParameter(string inParameterName)
	{
		return default(bool);
	}

	public void FeralAnimationEvent_StringParameter(string inStringParameter)
	{
	}

	private void ResetSpawnState(FeralAnimationEvents.EventInfo inEventInfo)
	{
	}

	public void PlayAudio(Object inObject)
	{
	}

	private void PlayAudio(FeralAnimationEvents.EventInfo inEventInfo)
	{
	}

	private void PlayFx(FeralAnimationEvents.EventInfo inEventInfo)
	{
	}

	public void ExitAnimation()
	{
	}
}
