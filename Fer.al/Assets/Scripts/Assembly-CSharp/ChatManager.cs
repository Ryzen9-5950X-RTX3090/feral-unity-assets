using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Services.Chat;
using UniRx.Async;
using UniRx.Async.CompilerServices;
using WW.Debug;

public class ChatManager : SingletonManagerBase<ChatManager>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <KeepAlive>d__20 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public ChatManager <>4__this;

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
	private struct <OnLoginComplete>d__26 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public ChatManager <>4__this;

		private UniTask<List<ChatConversationData>>.Awaiter <>u__1;

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
	private struct <OnRoomJoin>d__27 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public ChatManager <>4__this;

		public RoomJoinSuccessMessage inMessage;

		private ConversationAddResponse <addResponse>5__2;

		private ChatConversationGetResponse <roomConversation>5__3;

		private UniTask.Awaiter <>u__1;

		private UniTask<ConversationAddResponse>.Awaiter <>u__2;

		private UniTask<ChatConversationGetResponse>.Awaiter <>u__3;

		private UniTask<bool>.Awaiter <>u__4;

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
	private struct <OnChatConversationMessage>d__28 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public ChatConversationServiceMessage inMessage;

		public ChatManager <>4__this;

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
	private struct <OnChatConversationMessage_Private>d__30 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public ChatManager <>4__this;

		public ChatConversationServiceMessage inMessage;

		private UniTask<ChatConversationData>.Awaiter <>u__1;

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
	private struct <GetConversation>d__31 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder<ChatConversationData> <>t__builder;

		public string inConvoId;

		public ChatManager <>4__this;

		public bool inOnlyCheckCache;

		private ChatConversationData <conversation>5__2;

		private ChatConversationGetResponse <conversationResponse>5__3;

		private UniTask<ChatConversationGetResponse>.Awaiter <>u__1;

		private UniTask.Awaiter <>u__2;

		private UniTask<bool>.Awaiter <>u__3;

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
	private struct <GetOrCreateConversation>d__32 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder<ChatConversationData> <>t__builder;

		public string inOtherParticipantUUID;

		public ChatManager <>4__this;

		private ChatConversationData <conversation>5__2;

		private UniTask<ChatConversationOpenResponse>.Awaiter <>u__1;

		private UniTask<ChatConversationData>.Awaiter <>u__2;

		private UniTask<ChatConversationCreateResponse>.Awaiter <>u__3;

		private UniTask<UserInfo>.Awaiter <>u__4;

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
	private struct <GetConversations>d__33 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder<List<ChatConversationData>> <>t__builder;

		public ChatManager <>4__this;

		private ChatConversationListResponse <response>5__2;

		private UniTask.Awaiter <>u__1;

		private UniTask<ChatConversationListResponse>.Awaiter <>u__2;

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
	private struct <SendMessage>d__36 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public ChatManager <>4__this;

		public string inMessage;

		public string conversationId;

		public string inOtherParticipantUUID;

		private UniTask<ChatConversationServiceMessage>.Awaiter <>u__1;

		private UniTask<UserInfo>.Awaiter <>u__2;

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
	private struct <CreateConversation>d__37 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncUniTaskMethodBuilder<string> <>t__builder;

		public string inName;

		public string inConversationType;

		public string[] inParticipants;

		private UniTask<ChatConversationCreateResponse>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private ChatConversationData _roomConversation;

	private const int CONVERSATION_CACHE_SIZE = 20;

	private ChatConversationData _openConversation;

	private List<ChatConversationData> _cachedConversations;

	private List<string> _unreadConversations;

	private ChatConversationData _conversationBeingRead;

	private ChatThrottler _chatThrottler;

	private List<ChatEmojiDefComponent> _chatEmojis;

	public ChatConversationData RoomConversation
	{
		get
		{
			return null;
		}
	}

	public List<ChatConversationData> Conversations
	{
		get
		{
			return null;
		}
	}

	public List<string> UnreadConversations
	{
		get
		{
			return null;
		}
	}

	public ChatConversationData ConversationBeingRead
	{
		get
		{
			return null;
		}
	}

	public List<ChatEmojiDefComponent> ChatEmojis
	{
		get
		{
			return null;
		}
	}

	public override void Init()
	{
	}

	public override void Deinit()
	{
	}

	[AsyncStateMachine(typeof(<KeepAlive>d__20))]
	private void KeepAlive()
	{
	}

	private void LoadEmojiList()
	{
	}

	private void OnUserBlocked(UserBlockedMessage inMessage)
	{
	}

	private void OnUserUnblocked(UserUnblockedMessage inMessage)
	{
	}

	private void OnChatFilterSettingChanged(ChatFilterSettingChangedMessage inMessage)
	{
	}

	private void RefreshChatsWithUser(string inUUID)
	{
	}

	[AsyncStateMachine(typeof(<OnLoginComplete>d__26))]
	private void OnLoginComplete(LoginCompleteMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<OnRoomJoin>d__27))]
	private void OnRoomJoin(RoomJoinSuccessMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<OnChatConversationMessage>d__28))]
	private void OnChatConversationMessage(ChatConversationServiceMessage inMessage)
	{
	}

	private void OnChatConversationMessage_Room(ChatConversationServiceMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<OnChatConversationMessage_Private>d__30))]
	private void OnChatConversationMessage_Private(ChatConversationServiceMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<GetConversation>d__31))]
	public UniTask<ChatConversationData> GetConversation(string inConvoId, bool inOnlyCheckCache = false)
	{
		return default(UniTask<ChatConversationData>);
	}

	[AsyncStateMachine(typeof(<GetOrCreateConversation>d__32))]
	public UniTask<ChatConversationData> GetOrCreateConversation(string inOtherParticipantUUID)
	{
		return default(UniTask<ChatConversationData>);
	}

	[AsyncStateMachine(typeof(<GetConversations>d__33))]
	[DebugButton("Get Conversations", "Chat", false, false)]
	private UniTask<List<ChatConversationData>> GetConversations()
	{
		return default(UniTask<List<ChatConversationData>>);
	}

	public void MarkConversationAsOpen(ChatConversationData inConversation, bool inIsOpen)
	{
	}

	private void SetConversationUnreadState(string inConversationId, bool inIsRead)
	{
	}

	[AsyncStateMachine(typeof(<SendMessage>d__36))]
	public void SendMessage(string inMessage, string conversationId, [Optional] string inOtherParticipantUUID)
	{
	}

	[AsyncStateMachine(typeof(<CreateConversation>d__37))]
	public UniTask<string> CreateConversation(string inName, string inConversationType, string[] inParticipants)
	{
		return default(UniTask<string>);
	}

	public void JoinConversation(string inConversationId)
	{
	}

	public void InviteUserToConversation(string inUserUUID, string inConversationId)
	{
	}

	public void LeaveConversation(string inConversationId)
	{
	}

	private void SortCachedConversations()
	{
	}

	public string ProcessEmojiChatCommands(string inOriginalText)
	{
		return null;
	}

	public bool IsSingleEmojiChat(ChatEntry inChatEntry)
	{
		return default(bool);
	}
}
