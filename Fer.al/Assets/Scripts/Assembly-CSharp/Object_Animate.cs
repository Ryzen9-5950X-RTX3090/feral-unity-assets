using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

public class Object_Animate : ManagedBehaviour
{
	[Serializable]
	public class ObjectAnimItem
	{
		public string animClipName;

		public FeralAudioInfo startSound;

		public float animDelayMin;

		public float animDelayMax;
	}

	[SerializeField]
	private ObjectAnimItem defaultAnimation;

	[SerializeField]
	private ObjectAnimItem[] animations;

	[SerializeField]
	private Transform animSoundTransform;

	[SerializeField]
	private Animator _animator;

	public override void MStart()
	{
	}

	[IteratorStateMachine(typeof(<PlayLoopAnim>d__6))]
	private IEnumerator PlayLoopAnim()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<PlayAnimation>d__7))]
	private IEnumerator PlayAnimation(ObjectAnimItem inObjectAnimItem)
	{
		return null;
	}
}
