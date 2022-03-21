using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using LitJson;
using UniRx.Async;
using UniRx.Async.CompilerServices;

namespace Services.Chat
{
	public class ChatConversationData
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <InitializeChatEntries>d__21 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder <>t__builder;

			public ChatConversationData <>4__this;

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
		private struct <RequestAdditionalChats>d__22 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<bool> <>t__builder;

			public ChatConversationData <>4__this;

			public bool inGetOlder;

			private int <pageIndex>5__2;

			private int <endIndex>5__3;

			private UniTask<string>.Awaiter <>u__1;

			private UniTask<ChatConversationHistoryResponse>.Awaiter <>u__2;

			private UniTask.Awaiter <>u__3;

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
		private struct <GetCursor>d__23 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<string> <>t__builder;

			public ChatConversationData <>4__this;

			public int inPageIndex;

			private UniTask<ChatConversationHistoryResponse>.Awaiter <>u__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public string id;

		public string title;

		public List<string> participants;

		public List<ChatEntry> messages;

		private const int PAGE_SIZE = 50;

		private const int MAX_PAGES = 6;

		private int _cacheStartIndex;

		private float _cacheCooldown;

		private bool _canUpdateCache;

		private bool _hasOldestMessages;

		public Action<ChatEntry> OnCachedMessageAdded;

		public Action<ChatEntry> OnCachedMessageRemoved;

		private List<string> _cursors;

		private ChatEntry _mostRecentMessage;

		public bool HasAllMessages
		{
			get
			{
				return default(bool);
			}
		}

		public ChatEntry MostRecentMessage
		{
			get
			{
				return null;
			}
		}

		public bool IsRoomChat
		{
			get
			{
				return default(bool);
			}
		}

		public ChatConversationData(JsonData jsonData)
		{
		}

		[AsyncStateMachine(typeof(<InitializeChatEntries>d__21))]
		public UniTask InitializeChatEntries()
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(<RequestAdditionalChats>d__22))]
		public UniTask<bool> RequestAdditionalChats(bool inGetOlder)
		{
			return default(UniTask<bool>);
		}

		[AsyncStateMachine(typeof(<GetCursor>d__23))]
		private UniTask<string> GetCursor(int inPageIndex)
		{
			return default(UniTask<string>);
		}

		private void ConstrainCachedChats(bool inGetOlder, bool inReportRemovals)
		{
		}

		public void OnChatMessage(ChatEntry inChatEntry)
		{
		}
	}
}
