using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_ResetPassword : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <BtnClicked_ResetPassword>d__12 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_ResetPassword <>4__this;

		private TaskAwaiter<string> <>u__1;

		private TaskAwaiter<WWWResponse<PasswordResetResponse>> <>u__2;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private FeralButton _resetBtn;

	[SerializeField]
	private TMP_InputField _emailInput;

	private string Email
	{
		get
		{
			return null;
		}
	}

	public static void OpenWindow(string inEmail)
	{
	}

	public static void QueueWindow(string inEmail)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(string inEmail)
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

	public void OnEmailChanged()
	{
	}

	[AsyncStateMachine(typeof(<BtnClicked_ResetPassword>d__12))]
	public void BtnClicked_ResetPassword()
	{
	}

	private bool IsValidEmail()
	{
		return default(bool);
	}
}
