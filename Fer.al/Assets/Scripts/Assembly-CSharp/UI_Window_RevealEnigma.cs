using System;
using System.Collections.Generic;
using UnityEngine;

public class UI_Window_RevealEnigma : UI_Window
{
	public enum EnigmaType
	{
		Stag,
		Beetle,
		Twiggle
	}

	[SerializeField]
	private float _animationDuration;

	[SerializeField]
	[EnumList(typeof(EnigmaType), 0.35f)]
	private List<GameObject> _enigmaFX;

	public Action OnEnigmaRevealComplete;

	public static void OpenWindow(EnigmaType inEnigmaType, Action inOnCompleteAction)
	{
	}

	public static void QueueWindow(EnigmaType inEnigmaType, Action inOnCompleteAction)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(EnigmaType inEnigmaType, Action inOnCompleteAction)
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	public override void MOnDestroy()
	{
	}
}
