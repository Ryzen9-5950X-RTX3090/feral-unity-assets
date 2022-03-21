using System;
using UnityEngine;
using UnityEngine.Playables;

[Serializable]
public class TimelineEventBehaviour : PlayableBehaviour
{
	public string HandlerKey;

	public bool IsMethodWithParam;

	public bool InvokeEventsInEditMode;

	public GameObject TargetObject;

	public string ArgValue;

	private TimelineEventInvocationInfo invocationInfo;

	private bool _hasFired;

	public override void OnBehaviourPlay(Playable playable, FrameData info)
	{
	}

	public override void OnBehaviourPause(Playable playable, FrameData info)
	{
	}

	public override void OnPlayableCreate(Playable playable)
	{
	}

	public override void OnPlayableDestroy(Playable playable)
	{
	}

	private void UpdateDelegates()
	{
	}

	private TimelineEventInvocationInfo GetInvocationInfo(bool isEnabled, string methodKey, TimelineEventInvocationInfo currentInfo, bool methodWitharg)
	{
		return null;
	}

	private void GetBehaviourAndMethod(bool isEnabled, string key, ref Behaviour targetBehaviour, ref string methodName)
	{
	}
}
