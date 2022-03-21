using System;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class UI_Window_YesNoDontAskAgain : UI_Window
{
	[SerializeField]
	[Header("YesNoDontAskAgain Popup")]
	private GameObject _headerGroup;

	[SerializeField]
	private WWTextMeshProUGUI _titleText;

	[SerializeField]
	private WWTextMeshProUGUI _messageText;

	[SerializeField]
	private WWTextMeshProUGUI _yesBtnText;

	[SerializeField]
	private WWTextMeshProUGUI _noBtnText;

	[SerializeField]
	private WWTextMeshProUGUI _checkboxText;

	[SerializeField]
	private GameObject _checkmarkImage;

	private Action<bool> _responseCallback;

	private Action<bool> _checkboxCallback;

	public static void OpenWindow(string inTitle = "", string inMessage = "", string inYesBtnText = "", string inNoBtnText = "", string inCheckboxText = "", [Optional] Action<bool> inResponseCallback, [Optional] Action<bool> inCheckboxCallback)
	{
	}

	public static void QueueWindow(string inTitle = "", string inMessage = "", string inYesBtnText = "", string inNoBtnText = "", string inCheckboxText = "", [Optional] Action<bool> inResponseCallback, [Optional] Action<bool> inCheckboxCallback)
	{
	}

	public static void CloseWindow()
	{
	}

	public void Setup(string inTitle = "", string inMessage = "", string inYesBtnText = "", string inNoBtnText = "", string inCheckboxText = "", [Optional] Action<bool> inResponseCallback, [Optional] Action<bool> inCheckboxCallback)
	{
	}

	public void BtnClicked_Response(bool inResponse)
	{
	}

	public void CheckboxToggled_Response(bool inResponse)
	{
	}
}
