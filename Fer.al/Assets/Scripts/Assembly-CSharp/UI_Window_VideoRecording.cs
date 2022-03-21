using System.Collections;
using System.Runtime.CompilerServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_VideoRecording : UI_Window
{
	[SerializeField]
	private WWTextMeshProUGUI _timerText;

	[SerializeField]
	private Transform _touchControlParent;

	[SerializeField]
	private FeralButton _takeSelfieButton;

	private Transform _prevTouchControlParent;

	private UI_Window_YesNoDontAskAgain _dialogueWindow;

	private string EndRecording
	{
		get
		{
			return null;
		}
	}

	private string EndRecordingWithoutSaving
	{
		get
		{
			return null;
		}
	}

	private string End
	{
		get
		{
			return null;
		}
	}

	private string GoBack
	{
		get
		{
			return null;
		}
	}

	private static bool IsAskingForConfirmation
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	private static string ConfirmationVariableName
	{
		get
		{
			return null;
		}
	}

	private bool IsVisible
	{
		get
		{
			return default(bool);
		}
	}

	public static void OpenWindow()
	{
	}

	public static void QueueWindow()
	{
	}

	public static void CloseWindow()
	{
	}

	public void BtnClicked_StopRecording()
	{
	}

	public void BtnClicked_CancelRecording()
	{
	}

	[IteratorStateMachine(typeof(<AttachTouchToConfirmation>d__26))]
	private IEnumerator AttachTouchToConfirmation()
	{
		return null;
	}

	private void AttachTouchToParent(bool setPrevParent = true)
	{
	}

	private void Update()
	{
	}

	private void Setup()
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}

	private void OnHideHUDCommand(HideHUDCommand inCommand)
	{
	}

	private void Cancel()
	{
	}
}
