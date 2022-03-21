using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FMODUnity;
using UnityEngine;

[ManagedBehaviourManager("FeralAudioManager")]
public class FeralAudioEmitter : ManagedBehaviour
{
	public FeralEmitterGameEvent playEvent;

	public FeralEmitterGameEvent stopEvent;

	public FeralAudioInfo audioInfo;

	public string collisionTag;

	private bool _isQuitting;

	public override void MStart()
	{
	}

	private void OnApplicationQuit()
	{
	}

	public override void MOnDestroy()
	{
	}

	public override void MOnEnable()
	{
	}

	public override void MOnDisable()
	{
	}

	private void OnTriggerEnter(Collider other)
	{
	}

	private void OnTriggerExit(Collider other)
	{
	}

	private void OnTriggerEnter2D(Collider2D other)
	{
	}

	private void OnTriggerExit2D(Collider2D other)
	{
	}

	private void OnCollisionEnter()
	{
	}

	private void OnCollisionExit()
	{
	}

	private void OnCollisionEnter2D()
	{
	}

	private void OnCollisionExit2D()
	{
	}

	public void HandleGameEvent(FeralEmitterGameEvent gameEvent)
	{
	}

	public void HandleGameEvent(FeralEmitterGameEvent gameEvent, GameObject inParent)
	{
	}

	private void Play(GameObject inParent)
	{
	}

	public void Play()
	{
	}

	public void Stop([Optional] GameObject inParent)
	{
	}

	[IteratorStateMachine(typeof(<WaitForFeralAudioManager>d__23))]
	private IEnumerator WaitForFeralAudioManager()
	{
		return null;
	}

	public void SetParameters(ParamRef[] inParameters)
	{
	}
}
