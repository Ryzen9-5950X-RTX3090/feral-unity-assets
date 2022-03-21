using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TMPro;
using UniRx.Async;
using UnityEngine;
using UnityEngine.EventSystems;

public class UI_ChatItem : MonoBehaviour, ISelectHandler, IEventSystemHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Setup>d__5 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public UI_ChatItem <>4__this;

		public string inUserId;

		public string inContent;

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
	private WWTextMeshProUGUI _contentText;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private Color _nameTextColorMe;

	[SerializeField]
	private Color _nameTextColorOther;

	private Action<UI_ChatItem> _onSelectedAction;

	[AsyncStateMachine(typeof(<Setup>d__5))]
	public void Setup(string inUserId, string inContent, [Optional] Action<UI_ChatItem> inSelectedAction, bool inFromSetup = false)
	{
	}

	public void OnSelect(BaseEventData eventData)
	{
	}

	public void SetTextSize(int inTextSize)
	{
	}
}
