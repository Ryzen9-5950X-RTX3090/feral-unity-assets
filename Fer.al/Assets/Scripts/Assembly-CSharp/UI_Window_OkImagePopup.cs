using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_OkImagePopup : UI_Window
{
	[SerializeField]
	private WWTextMeshProUGUI _headerText;

	[SerializeField]
	private WWTextMeshProUGUI _messageTitleText;

	[SerializeField]
	private WWTextMeshProUGUI _messageText;

	[SerializeField]
	private WWTextMeshProUGUI _okBtnText;

	[SerializeField]
	private WWImage _iconImage;

	private Action _okCallback;

	public static void OpenWindow(string inHeader = "", string inMessageTitle = "", string inMessage = "", string inOkBtnText = "", string inImageDefId = "-1", [Optional] Action inOkCallback)
	{
	}

	public static void QueueWindow(string inHeader = "", string inMessageTitle = "", string inMessage = "", string inOkBtnText = "", string inImageDefId = "-1", [Optional] Action inOkCallback)
	{
	}

	public static void CloseWindow()
	{
	}

	public void Setup(string inHeader = "", string inMessageTitle = "", string inMessage = "", string inOkBtnText = "", string inImageDefId = "-1", [Optional] Action inOkCallback)
	{
	}

	public void BtnClicked_Ok()
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
