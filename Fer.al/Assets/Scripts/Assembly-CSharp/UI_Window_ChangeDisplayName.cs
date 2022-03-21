using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_ChangeDisplayName : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <DoRename>d__21 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_ChangeDisplayName <>4__this;

		private TaskAwaiter<WWWResponse<RenameDisplayNameResponse>> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private FeralButton _submitBtn;

	[SerializeField]
	[Header("Username")]
	private UI_FieldStatusIndicator _usernameStatusIndicator;

	[SerializeField]
	private TMP_InputField _usernameInput;

	[SerializeField]
	private WWTextMeshProUGUI _usernameErrorText;

	private string _renameRequiredKey;

	private bool _renaming;

	private Action _renameSuccessCallback;

	private string Username
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static void OpenWindow(string inRenameRequiredKey, Action inRenameSuccessCallback)
	{
	}

	public static void QueueWindow(string inRenameRequiredKey, Action inRenameSuccessCallback)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(string inRenameRequiredKey, Action inRenameSuccessCallback)
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

	public void OnInputFieldChanged_Username(string inValue)
	{
	}

	private void OnInputFieldSubmit_Username(string inValue)
	{
	}

	public void BtnClicked_Submit()
	{
	}

	private void Refresh()
	{
	}

	[AsyncStateMachine(typeof(<DoRename>d__21))]
	private void DoRename()
	{
	}
}
