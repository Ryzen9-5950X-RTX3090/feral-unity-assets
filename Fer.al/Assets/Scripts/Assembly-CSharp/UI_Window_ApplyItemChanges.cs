using System;
using System.Runtime.InteropServices;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_ApplyItemChanges : UI_Window
{
	[SerializeField]
	private RawImage _rawImage;

	private Action<bool> _responseCallback;

	public static void OpenWindow(Item inItem, [Optional] Action<bool> inResponseCallback)
	{
	}

	public static void QueueWindow(Item inItem, [Optional] Action<bool> inResponseCallback)
	{
	}

	public static void CloseWindow()
	{
	}

	public void Setup(Item inItem, [Optional] Action<bool> inResponseCallback)
	{
	}

	public void BtnClicked_Response(bool inResponse)
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
