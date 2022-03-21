using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Services.Chat;
using TMPro;
using UniRx.Async;
using UnityEngine;

public class UI_ChatConversationItem : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Setup>d__12 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_ChatConversationItem <>4__this;

		public ChatConversationData inData;

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
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private WWTextMeshProUGUI _participantNameText;

	[SerializeField]
	private WWTextMeshProUGUI _lastChatMessageText;

	[SerializeField]
	private WWTextMeshProUGUI _lastChatTimeText;

	[SerializeField]
	private UI_OnlineStatus _onlineStatus;

	[SerializeField]
	private Color _chatTextColorMe;

	[SerializeField]
	private Color _chatTextColorOther;

	private ChatConversationData _conversationData;

	public ChatConversationData ConversationData
	{
		get
		{
			return null;
		}
	}

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	[AsyncStateMachine(typeof(<Setup>d__12))]
	public void Setup(ChatConversationData inData)
	{
	}

	public void SetTextSize(int inTextSize)
	{
	}

	private void OnChatMessage(ChatConversationMessage inMessage)
	{
	}

	private void RefreshLastChatEntry(ChatEntry inChatEntry)
	{
	}
}
