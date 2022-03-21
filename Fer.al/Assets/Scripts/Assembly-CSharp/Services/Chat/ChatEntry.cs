using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading;
using LitJson;
using UniRx.Async;
using UniRx.Async.CompilerServices;

namespace Services.Chat
{
	public class ChatEntry
	{
		public struct ChatDisplayData
		{
			public readonly string DisplayName;

			public readonly string DisplayMessage;

			public readonly string DisplayMessageWithBlockIgnored;

			public ChatDisplayData(string displayName, string displayMessage, string displayMessageWithBlockIgnored)
			{
			}
		}

		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <RefreshDisplayData>d__24 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder <>t__builder;

			public ChatEntry <>4__this;

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
		private struct <RefreshDisplayData>d__25 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder <>t__builder;

			public ChatEntry <>4__this;

			public CancellationToken inCancellationToken;

			private string <displayName>5__2;

			private UniTask<UserInfo>.Awaiter <>u__1;

			private UniTask<bool>.Awaiter <>u__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public string sourceUUID;

		private UserInfo _sourceUserInfo;

		private string _message;

		private string _filteredMessage;

		public List<string> mask;

		public readonly DateTime timeStamp;

		public readonly DateTime localTimeStamp;

		public string conversationId;

		public bool allowed;

		public readonly string ConversationType;

		private CancellationTokenSource _cancellationTokenSource;

		private ChatDisplayData _displayData;

		public Action<ChatDisplayData> OnDisplayDataChanged;

		public ChatDisplayData DisplayData
		{
			get
			{
				return default(ChatDisplayData);
			}
		}

		public bool IsMe
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsFiltered
		{
			get
			{
				return default(bool);
			}
		}

		public ChatEntry(string message)
		{
		}

		public ChatEntry(JsonData jsonData, [Optional] string inConversationId)
		{
		}

		private string FilteredMessage(string message, List<string> maskArray)
		{
			return null;
		}

		public bool IsSingleEmojiMessage(List<ChatEmojiDefComponent> inEmojiDefs)
		{
			return default(bool);
		}

		public string GetTimeStampUIString()
		{
			return null;
		}

		[AsyncStateMachine(typeof(<RefreshDisplayData>d__24))]
		public UniTask RefreshDisplayData()
		{
			return default(UniTask);
		}

		[AsyncStateMachine(typeof(<RefreshDisplayData>d__25))]
		private UniTask RefreshDisplayData(CancellationToken inCancellationToken)
		{
			return default(UniTask);
		}
	}
}
