using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class UI_OnlineStatus : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Setup>d__7 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_OnlineStatus <>4__this;

		public string inUserUUID;

		private TaskAwaiter<bool> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private CanvasGroup _groupOnline;

	private string _userUUID;

	private float _timeLastRefreshed;

	public bool isOnline
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	[AsyncStateMachine(typeof(<Setup>d__7))]
	public void Setup(string inUserUUID)
	{
	}

	private void SetStatus(bool inStatus)
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void Update()
	{
	}

	private void OnUserOnlineStatusChanged(UserOnlineStatusMessage inMessage)
	{
	}
}
