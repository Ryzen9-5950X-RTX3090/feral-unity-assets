using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Services.Chat;
using TMPro;
using UniRx.Async;
using UnityEngine;

public class UI_LazyListItem_ChatConversation : UI_LazyListItem<ChatConversationData>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Setup>d__12 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_LazyListItem_ChatConversation <>4__this;

		public Action<UI_LazyListItem<ChatConversationData>> inOnClicked;

		public Action<UI_LazyListItem<ChatConversationData>> inOnSelected;

		public ChatConversationData inData;

		public UI_LazyItemList<ChatConversationData> inItemList;

		private string <otherUserId>5__2;

		private UniTask<UserInfo>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	private WWTextMeshProUGUI _participantNameText;

	[SerializeField]
	private WWTextMeshProUGUI _lastChatMessageText;

	[SerializeField]
	private WWTextMeshProUGUI _lastChatTimeText;

	[SerializeField]
	private Color _timeColorRead;

	[SerializeField]
	private Color _timeColorUnread;

	[SerializeField]
	private UI_OnlineStatus _onlineStatus;

	[SerializeField]
	private Color _chatTextColorMe;

	[SerializeField]
	private Color _chatTextColorOther;

	[SerializeField]
	private RectTransform _windowBody;

	[SerializeField]
	private List<GameObject> _offOnCompressGameObjects;

	[SerializeField]
	private List<GameObject> _onOnCompressGameObjects;

	[SerializeField]
	private float _compressedWidthThreshold;

	[AsyncStateMachine(typeof(<Setup>d__12))]
	public override void Setup(Action<UI_LazyListItem<ChatConversationData>> inOnClicked, Action<UI_LazyListItem<ChatConversationData>> inOnSelected, ChatConversationData inData, UI_LazyItemList<ChatConversationData> inItemList)
	{
	}

	protected override void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetTextSize(int inTextSize)
	{
	}

	private void OnChatMessage(ChatConversationMessage inMessage)
	{
	}

	private void OnConversationReadStateChanged(ConversationReadStateChangedMessage inMessage)
	{
	}

	private void RefreshLastChatEntry(ChatEntry inChatEntry)
	{
	}

	private void RefreshReadState(bool inIsRead)
	{
	}

	public override void MarkAsSelected(bool inIsSelected)
	{
	}

	public void RefreshCompression()
	{
	}
}
