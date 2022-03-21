using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

[ExecuteAlways]
public class UI_Window_OkPopup : UI_Window
{
	[SerializeField]
	[Header("OK Popup")]
	protected RectTransform _rootLayout;

	[SerializeField]
	private RectTransform _body;

	[SerializeField]
	protected WWTextMeshProUGUI _titleText;

	[SerializeField]
	protected WWTextMeshProUGUI _messageText;

	[SerializeField]
	protected WWTextMeshProUGUI _okBtnText;

	[SerializeField]
	private List<SizeBucket> _sizeBuckets;

	private Action _okCallback;

	public static void OpenWindow(string inTitle = "", string inMessage = "", string inOkBtnText = "", [Optional] Action inOkCallback)
	{
	}

	public static void QueueWindow(string inTitle = "", string inMessage = "", string inOkBtnText = "", [Optional] Action inOkCallback)
	{
	}

	public static void CloseWindow()
	{
	}

	public void Setup(string inTitle = "", string inMessage = "", string inOkBtnText = "", [Optional] Action inOkCallback)
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

	private void RefreshBodySize()
	{
	}

	private void Update()
	{
	}
}
