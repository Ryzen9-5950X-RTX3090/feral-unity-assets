using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UnityEngine;

public class UI_Window_FindVoicePlayer : UI_Window
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <OnSearchSubmit>d__9 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_Window_FindVoicePlayer <>4__this;

		public string inSearch;

		private float <time>5__2;

		private string <result>5__3;

		private TaskAwaiter<string> <>u__1;

		private TaskAwaiter <>u__2;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private TMP_InputField _searchInputField;

	[SerializeField]
	[Header("Groups")]
	private CanvasGroup _groupInitial;

	[SerializeField]
	private CanvasGroup _groupPlayerFound;

	[SerializeField]
	private CanvasGroup _groupPlayerNotFound;

	[SerializeField]
	private GameObject _waitingGroup;

	private string _previousSearch;

	public static void OpenWindow()
	{
	}

	public static void QueueWindow()
	{
	}

	public static void CloseWindow()
	{
	}

	[AsyncStateMachine(typeof(<OnSearchSubmit>d__9))]
	public void OnSearchSubmit(string inSearch)
	{
	}

	private void OnSearchResult(string inUUID)
	{
	}

	protected override void OnOpen()
	{
	}

	protected override void OnClose(bool inAnimate)
	{
	}
}
