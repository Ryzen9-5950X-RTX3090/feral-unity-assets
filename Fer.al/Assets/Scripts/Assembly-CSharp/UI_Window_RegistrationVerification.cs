using System;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_RegistrationVerification : UI_Window
{
	[SerializeField]
	private TMP_InputField _codeInput;

	[SerializeField]
	private UI_FieldStatusIndicator _codeStatusIndicator;

	[SerializeField]
	private WWTextMeshProUGUI _codeErrorText;

	[SerializeField]
	private FeralButton _submitBtn;

	private Action<string> callback;

	public string Code
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static void OpenWindow(Action<string> inCodeCallback, string inFailedCode = "")
	{
	}

	public static void QueueWindow(Action<string> inCodeCallback, string inFailedCode = "")
	{
	}

	public static void CloseWindow()
	{
	}

	public void BtnClicked_Submit()
	{
	}

	public void OnInputFieldChanged_Code(string inValue)
	{
	}

	public void BtnClicked_Cancel()
	{
	}

	private void Setup(Action<string> inCodeCallback, string inFailedCode = "")
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

	private void Refresh()
	{
	}

	private void OnCodeSubmitted(string inCode)
	{
	}
}
