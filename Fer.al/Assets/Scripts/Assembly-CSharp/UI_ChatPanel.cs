using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Services.Chat;
using TMPro;
using UniRx.Async;
using UnityEngine;
using UnityEngine.UI;

public abstract class UI_ChatPanel : MonoBehaviour
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <SnapToBottom>d__29 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_ChatPanel <>4__this;

		public bool inInstant;

		private UniTask<int>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	protected const int MAX_CHAT_ITEMS = 10000;

	[SerializeField]
	protected UI_LazyItemList_ChatEntry _itemList;

	[SerializeField]
	protected ScrollRect _scrollRect;

	[SerializeField]
	protected TMP_InputField _chatInput;

	[SerializeField]
	protected CanvasGroup _scrollToBottomGroup;

	protected List<UI_ChatItem> _chatItems;

	protected bool _isAtBottom;

	protected bool _ignoreScrollChanges;

	protected bool IsAtBottom
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	protected virtual void Awake()
	{
	}

	protected virtual void OnDestroy()
	{
	}

	protected virtual void OnEnable()
	{
	}

	protected virtual void OnDisable()
	{
	}

	public void SelectInputField()
	{
	}

	public void BtnClicked_SubmitChat()
	{
	}

	public void BtnClicked_ScrollToBottom()
	{
	}

	public virtual void SubmitChat(string inChatText)
	{
	}

	protected virtual void OnValueChanged(string inChatText)
	{
	}

	public virtual void RecalculateLayout()
	{
	}

	protected virtual string PrepareChatForSubmission(string inChatText)
	{
		return null;
	}

	protected virtual void DoChatSubmission(string inChatText)
	{
	}

	protected virtual void CreateChatConversation()
	{
	}

	protected static string ReplaceCaseInsensitive(string input, string search, string replacement)
	{
		return null;
	}

	public void SetTextSize(int inTextSize)
	{
	}

	public virtual void OnScrollPositionChanged(Vector2 inPosition)
	{
	}

	protected abstract void SpawnInitialChatItems();

	protected virtual void SpawnChatItem(ChatEntry inChatEntry, bool inFromSetup = false)
	{
	}

	[AsyncStateMachine(typeof(<SnapToBottom>d__29))]
	protected void SnapToBottom(bool inInstant = true)
	{
	}
}
