using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class UI_Window_YesNoPopup : UI_Window
{
	[SerializeField]
	[Header("YesNo Popup")]
	private GameObject _headerGroup;

	[SerializeField]
	private WWTextMeshProUGUI _titleText;

	[SerializeField]
	private WWTextMeshProUGUI _messageText;

	[SerializeField]
	private WWTextMeshProUGUI _yesBtnText;

	[SerializeField]
	private WWTextMeshProUGUI _noBtnText;

	private Action<bool> _responseCallback;

	public static void OpenWindow(string inTitle = "", string inMessage = "", string inYesBtnText = "", string inNoBtnText = "", [Optional] Action<bool> inResponseCallback)
	{
	}

	public static void QueueWindow(string inTitle = "", string inMessage = "", string inYesBtnText = "", string inNoBtnText = "", [Optional] Action<bool> inResponseCallback)
	{
	}

	public static void CloseWindow()
	{
	}

	public void Setup(string inTitle = "", string inMessage = "", string inYesBtnText = "", string inNoBtnText = "", [Optional] Action<bool> inResponseCallback)
	{
	}

	public void BtnClicked_Response(bool inResponse)
	{
	}
}
