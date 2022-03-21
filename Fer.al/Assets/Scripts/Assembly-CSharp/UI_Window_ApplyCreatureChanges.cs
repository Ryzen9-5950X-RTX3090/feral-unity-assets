using System;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_ApplyCreatureChanges : UI_Window
{
	[SerializeField]
	private RawImage _avatarIcon;

	private CreatureCustomizationTarget _currentCustomizationTarget;

	private ActorInfo _oldActorInfo;

	private Action<bool> _onProceedResult;

	public static void OpenWindow(CreatureCustomizationTarget inCurrentCustomizationTarget, ActorInfo inOldActorInfo, Action<bool> inOnProceedResult)
	{
	}

	public static void QueueWindow(CreatureCustomizationTarget inCurrentCustomizationTarget, ActorInfo inOldActorInfo, Action<bool> inOnProceedResult)
	{
	}

	public static void CloseWindow()
	{
	}

	public void Setup(CreatureCustomizationTarget inCurrentCustomizationTarget, ActorInfo inOldActorInfo, Action<bool> inOnProceedResult)
	{
	}

	public void BtnClicked_Apply()
	{
	}

	public void BtnClicked_Discard()
	{
	}

	public void BtnClicked_Cancel()
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
