using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Services.Chat;
using TMPro;
using UnityEngine;

public class UI_ChatConversationListItem : UI_SelectableListItem<ChatConversationData>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RefreshUsersText>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_ChatConversationListItem <>4__this;

		private TaskAwaiter<IdentityDisplayNamesResponse.Identity[]> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private WWTextMeshProUGUI _usersText;

	public override void Setup(ChatConversationData inData, Action<UI_SelectableListItem<ChatConversationData>> inOnClicked, Action<UI_SelectableListItem<ChatConversationData>> inOnLongPressed)
	{
	}

	[AsyncStateMachine(typeof(<RefreshUsersText>d__2))]
	private void RefreshUsersText()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnChatConversationJoined(ChatConversationJoinedMessage inMessage)
	{
	}

	private void OnChatConversationLeft(ChatConversationLeftMessage inMessage)
	{
	}
}
