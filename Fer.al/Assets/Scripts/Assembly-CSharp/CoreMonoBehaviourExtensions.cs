using System;
using UnityEngine;
using WW.Waiters;

public static class CoreMonoBehaviourExtensions
{
	public static WW.Waiters.Waiter DoNextFrame(this MonoBehaviour me, Action a)
	{
		return null;
	}

	public static WW.Waiters.Waiter DoAfterThreeFrames(this MonoBehaviour me, Action a)
	{
		return null;
	}

	public static WW.Waiters.Waiter DoAfterFrames(this MonoBehaviour me, int count, Action a)
	{
		return null;
	}

	public static WW.Waiters.Waiter DoAfterWait(this MonoBehaviour me, float seconds, Action a)
	{
		return null;
	}

	public static WW.Waiters.Waiter DoAfter(this MonoBehaviour me, Func<bool> inCompletionCheck, Action a)
	{
		return null;
	}

	public static void AddDebugButtons(this MonoBehaviour me)
	{
	}

	public static void RemoveDebugButtons(this MonoBehaviour me)
	{
	}

	public static void SetEnabled(this Behaviour me, bool value)
	{
	}
}
