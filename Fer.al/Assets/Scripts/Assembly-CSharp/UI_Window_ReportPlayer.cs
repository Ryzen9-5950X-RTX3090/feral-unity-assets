using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_Window_ReportPlayer : UI_Window
{
	public enum ReportCategory
	{
		BadUsername,
		Harassment,
		Spamming,
		TermsOfService,
		Other
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <BtnClicked_ReportPlayer>d__14 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_ReportPlayer <>4__this;

		private TaskAwaiter<FacilitatorReportUserMessage> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private TMP_InputField _input;

	[SerializeField]
	private FeralButton _submitButton;

	private ReportCategory _category;

	private UserInfo _userInfo;

	public ReportCategory Category
	{
		get
		{
			return default(ReportCategory);
		}
		set
		{
		}
	}

	public static void OpenWindow(UserInfo inUser)
	{
	}

	public static void QueueWindow(UserInfo inUser)
	{
	}

	public static void CloseWindow()
	{
	}

	private void Setup(UserInfo inUser)
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

	[AsyncStateMachine(typeof(<BtnClicked_ReportPlayer>d__14))]
	public void BtnClicked_ReportPlayer()
	{
	}

	public void OnDropDownItemSelected_Category(int inCategory)
	{
	}

	public void OnFeedbackTextUpdated(string inText)
	{
	}
}
