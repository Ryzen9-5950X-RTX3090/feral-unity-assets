using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Server;
using UniRx.Async;
using UniRx.Async.CompilerServices;

namespace Services.Chat
{
	[MessageRouteHandler]
	public static class ChatSrvHandler
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <RequestConversation>d__3 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ChatConversationGetResponse> <>t__builder;

			public string inConversationId;

			private TaskAwaiter<ChatConversationGetResponse> <>u__1;

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
		private struct <RequestConversationCreate>d__4 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ChatConversationCreateResponse> <>t__builder;

			public string inName;

			public string inConversationType;

			public string[] inParticipants;

			private TaskAwaiter<ChatConversationCreateResponse> <>u__1;

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
		private struct <RequestConversationWithUser>d__5 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ChatConversationOpenResponse> <>t__builder;

			public string inOtherParticipantUUID;

			private TaskAwaiter<ChatConversationOpenResponse> <>u__1;

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
		private struct <RequestConversations>d__6 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ChatConversationListResponse> <>t__builder;

			public string inCursor;

			public int inPageSize;

			private TaskAwaiter<ChatConversationListResponse> <>u__1;

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
		private struct <RequestConversationHistory>d__7 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ChatConversationHistoryResponse> <>t__builder;

			public string inConversationId;

			public string inCursor;

			public int inPageSize;

			public bool inIncludeMessages;

			private TaskAwaiter<ChatConversationHistoryResponse> <>u__1;

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
		private struct <RequestConversationAdd>d__9 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ConversationAddResponse> <>t__builder;

			public string conversationId;

			public string playerIdToAdd;

			private TaskAwaiter<ConversationAddResponse> <>u__1;

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
		private struct <SendMessage>d__11 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<ChatConversationServiceMessage> <>t__builder;

			public string message;

			public string conversationId;

			private TaskAwaiter<ChatConversationServiceMessage> <>u__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static ChatServiceRequests.ChatPingRequest _pingRequest;

		public static void RequestSessionStart()
		{
		}

		public static void Ping()
		{
		}

		[AsyncStateMachine(typeof(<RequestConversation>d__3))]
		public static UniTask<ChatConversationGetResponse> RequestConversation(string inConversationId)
		{
			return default(UniTask<ChatConversationGetResponse>);
		}

		[AsyncStateMachine(typeof(<RequestConversationCreate>d__4))]
		public static UniTask<ChatConversationCreateResponse> RequestConversationCreate(string inName, string inConversationType, string[] inParticipants)
		{
			return default(UniTask<ChatConversationCreateResponse>);
		}

		[AsyncStateMachine(typeof(<RequestConversationWithUser>d__5))]
		public static UniTask<ChatConversationOpenResponse> RequestConversationWithUser(string inOtherParticipantUUID)
		{
			return default(UniTask<ChatConversationOpenResponse>);
		}

		[AsyncStateMachine(typeof(<RequestConversations>d__6))]
		public static UniTask<ChatConversationListResponse> RequestConversations(string inCursor, int inPageSize)
		{
			return default(UniTask<ChatConversationListResponse>);
		}

		[AsyncStateMachine(typeof(<RequestConversationHistory>d__7))]
		public static UniTask<ChatConversationHistoryResponse> RequestConversationHistory(string inConversationId, string inCursor, int inPageSize, bool inIncludeMessages = true)
		{
			return default(UniTask<ChatConversationHistoryResponse>);
		}

		public static void RequestConversationRename(string newTitle, string conversationId)
		{
		}

		[AsyncStateMachine(typeof(<RequestConversationAdd>d__9))]
		public static UniTask<ConversationAddResponse> RequestConversationAdd(string conversationId, string playerIdToAdd)
		{
			return default(UniTask<ConversationAddResponse>);
		}

		public static void RequestConversationLeave(string conversationId)
		{
		}

		[AsyncStateMachine(typeof(<SendMessage>d__11))]
		public static UniTask<ChatConversationServiceMessage> SendMessage(string message, string conversationId)
		{
			return default(UniTask<ChatConversationServiceMessage>);
		}
	}
}
