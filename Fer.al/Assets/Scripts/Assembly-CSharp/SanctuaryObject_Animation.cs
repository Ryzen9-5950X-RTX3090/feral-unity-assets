using System.Collections.Generic;
using UnityEngine;

public class SanctuaryObject_Animation : SanctuaryObject_Interactable
{
	[SerializeField]
	private AnimationClip _animationClip;

	private List<SimpleAnimation> _simpleAnimations;

	public override void MOnEnable()
	{
	}

	public override void MStart()
	{
	}
}
