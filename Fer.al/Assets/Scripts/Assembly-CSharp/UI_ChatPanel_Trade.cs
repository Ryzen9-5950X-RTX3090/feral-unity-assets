using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Services.Chat;
using UniRx.Async;

public class UI_ChatPanel_Trade : UI_ChatPanel
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <CreateChatConversation>d__4 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_ChatPanel_Trade <>4__this;

		private UniTask<string>.Awaiter <>u__1;

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
	private struct <OnChatMessage>d__6 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_ChatPanel_Trade <>4__this;

		public ChatConversationServiceMessage inMessage;

		private UniTask.Awaiter <>u__1;

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
	private struct <OnItemAddedToTrade>d__8 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public ItemAddedToTradeMessage inMessage;

		public UI_ChatPanel_Trade <>4__this;

		private ChatEntry <chatEntry>5__2;

		private UniTask.Awaiter <>u__1;

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
	private struct <OnItemRemovedFromTrade>d__9 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public ItemRemovedFromTradeMessage inMessage;

		public UI_ChatPanel_Trade <>4__this;

		private ChatEntry <chatEntry>5__2;

		private UniTask.Awaiter <>u__1;

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
	private struct <SpawnInitialChatItems>d__11 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_ChatPanel_Trade <>4__this;

		private UniTask<int>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private string _conversationId;

	public void Setup(string inConversationId)
	{
	}

	protected override void Awake()
	{
	}

	protected override void OnDestroy()
	{
	}

	[AsyncStateMachine(typeof(<CreateChatConversation>d__4))]
	protected override void CreateChatConversation()
	{
	}

	protected override void DoChatSubmission(string inChatText)
	{
	}

	[AsyncStateMachine(typeof(<OnChatMessage>d__6))]
	private void OnChatMessage(ChatConversationServiceMessage inMessage)
	{
	}

	private void OnTradeChatConversationJoined(TradeChatConversationJoinedMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<OnItemAddedToTrade>d__8))]
	private void OnItemAddedToTrade(ItemAddedToTradeMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<OnItemRemovedFromTrade>d__9))]
	private void OnItemRemovedFromTrade(ItemRemovedFromTradeMessage inMessage)
	{
	}

	private void OnTradeConfirmationUpdated(TradeConfirmationUpdatedMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<SpawnInitialChatItems>d__11))]
	protected override void SpawnInitialChatItems()
	{
	}
}
