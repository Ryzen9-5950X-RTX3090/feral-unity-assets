using System;
using System.Collections.Generic;
using UnityEngine;

public class UI_ScreenSpaceTransformCanvas : ManagedBehaviour
{
	public enum ScreenSpaceTransformType
	{
		Namebar = 0,
		SanctuaryItem = 5
	}

	public static UI_ScreenSpaceTransformCanvas instance;

	private List<UI_ScreenSpaceTransform> _registeredTransforms;

	private Canvas _canvas;

	[SerializeField]
	private Canvas _namebarCanvas;

	[SerializeField]
	private Canvas _sanctuaryItemCanvas;

	public Canvas Canvas
	{
		get
		{
			return null;
		}
	}

	private void OnHideNamebarsCommand(HideNamebarsCommand inMessage)
	{
	}

	public void Register(UI_ScreenSpaceTransform inTransform)
	{
	}

	public void Unregister(UI_ScreenSpaceTransform inTransform)
	{
	}

	public QRoutine InstantiateFromBundleAndSetTarget<T>(string inBundleID, Transform inTargetTransform, ScreenSpaceTransformType inScreenSpaceTransformType, Action<T> inResult)
	{
		return null;
	}

	public void ShowQuickMenu(UI_ActorBubble inBubble)
	{
	}

	public void ShowQuickMenu(string inUUID)
	{
	}

	public override void MStart()
	{
	}

	public override void OnDestroy()
	{
	}

	public override void MOnEnable()
	{
	}

	public void SSTUpdate()
	{
	}
}
