using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Services.Chat;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using UnityEngine;

public class UI_ChatPanel_Room : UI_ChatPanel
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <SpawnInitialChatItems>d__13 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_ChatPanel_Room <>4__this;

		private int <attemptCount>5__2;

		private UniTask<bool>.Awaiter <>u__1;

		private UniTask<int>.Awaiter <>u__2;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestAdditionalChats>d__14 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_ChatPanel_Room <>4__this;

		public bool inGetOlder;

		private UniTask<bool>.Awaiter <>u__1;

		private UniTask.Awaiter <>u__2;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <OnChatChacheChanged>d__15 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder <>t__builder;

		public UI_ChatPanel_Room <>4__this;

		public bool inGetOlder;

		private UniTask.Awaiter <>u__1;

		private int <attemptCount>5__2;

		private UniTask<int>.Awaiter <>u__2;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private GameObject _inputGroup;

	[SerializeField]
	private CanvasGroup _contentGroup;

	private ChatConversationData _conversationData;

	private bool _requestingChats;

	public void Setup(ChatConversationData inData)
	{
	}

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	protected override void OnEnable()
	{
	}

	public override void OnScrollPositionChanged(Vector2 inPosition)
	{
	}

	protected override void DoChatSubmission(string inChatText)
	{
	}

	private void OnRoomConversationChanged(RoomConversationChangedMessage inMessage)
	{
	}

	private void OnCachedMessageAdded(ChatEntry inChatEntry)
	{
	}

	private void OnCachedMessageRemoved(ChatEntry inChatEntry)
	{
	}

	[AsyncStateMachine(typeof(<SpawnInitialChatItems>d__13))]
	protected override void SpawnInitialChatItems()
	{
	}

	[AsyncStateMachine(typeof(<RequestAdditionalChats>d__14))]
	private void RequestAdditionalChats(bool inGetOlder)
	{
	}

	[AsyncStateMachine(typeof(<OnChatChacheChanged>d__15))]
	private UniTask OnChatChacheChanged(bool inGetOlder)
	{
		return default(UniTask);
	}
}
