using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FMOD.Studio;
using UnityEngine;

[ManagedBehaviourManager("FeralAudioManager")]
public class FeralAudioBehaviour : ManagedBehaviour
{
	[Serializable]
	public class Info
	{
		public EventInstance instance;

		public EventDescription description;
	}

	private Rigidbody _cachedRigidbody;

	private List<string> _cachedSustained;

	private List<Info> _cachedSustainedInfos;

	private List<string> _cachedOneShots;

	private bool _hasTriggered;

	[IteratorStateMachine(typeof(<WaitForFeralAudioManager>d__6))]
	private IEnumerator WaitForFeralAudioManager()
	{
		return null;
	}

	public void Play(FeralAudioInfo inAudioInfo, [Optional] string inParameter, [Optional] float? inValue)
	{
	}

	private void UpdateSustained(Info inInfo, FeralAudioInfo inAudioInfo, [Optional] string inParameter, [Optional] float? inValue)
	{
	}

	private void SetParameter(EventInstance inInstance, [Optional] string inParameter, [Optional] float? inValue)
	{
	}

	private void Set3D(EventInstance inInstance, FeralAudioInfo inAudioInfo)
	{
	}

	private void PlayOneShot(FeralAudioInfo inAudioInfo, [Optional] string inParameter, [Optional] float? inValue)
	{
	}

	private void CreateInstance(FeralAudioInfo inAudioInfo, [Optional] string inParameter, [Optional] float? inValue)
	{
	}

	private void CreateSustained(FeralAudioInfo inAudioInfo, [Optional] string inParameter, [Optional] float? inValue)
	{
	}

	public void Stop(string inEventRef)
	{
	}

	public void Stop([Optional] FeralAudioInfo inAudioInfo)
	{
	}

	public void Kill([Optional] FeralAudioInfo inAudioInfo)
	{
	}

	private Info GetInfo(string inEventRef)
	{
		return null;
	}

	private Info GetInfo(FeralAudioInfo inAudioInfo)
	{
		return null;
	}

	public override void MOnDisable()
	{
	}

	public override void MOnDestroy()
	{
	}
}
