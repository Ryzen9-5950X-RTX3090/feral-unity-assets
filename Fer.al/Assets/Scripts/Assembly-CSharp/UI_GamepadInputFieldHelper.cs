using System;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class UI_GamepadInputFieldHelper : MonoBehaviour
{
	[Serializable]
	public class SubmitEvent : UnityEvent<string>
	{
	}

	[Serializable]
	public class CancelEvent : UnityEvent
	{
	}

	[SerializeField]
	private TMP_InputField _targetInputField;

	[SerializeField]
	private SubmitEvent OnSubmit;

	[SerializeField]
	private CancelEvent OnCancel;

	[SerializeField]
	private bool _restoreOnCancel;

	private bool _justSubmitted;

	private string _originalText;

	private void BtnClicked_Back()
	{
	}

	private void BtnClicked_Submit()
	{
	}

	public void OnClick()
	{
	}

	public void OnInputSelected()
	{
	}

	public void OnInputDeselected()
	{
	}
}
