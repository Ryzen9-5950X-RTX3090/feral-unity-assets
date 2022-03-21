using System;
using Services.Chat;
using TMPro;
using UnityEngine;

public class UI_LazyListItem_ChatEntry : UI_LazyListItem<ChatEntry>
{
	[SerializeField]
	private WWTextMeshProUGUI _contentText;

	[SerializeField]
	private CanvasGroup _canvasGroup;

	[SerializeField]
	private Color _nameTextColorMe;

	[SerializeField]
	private Color _nameTextColorOther;

	[SerializeField]
	private bool _ignoreBlockState;

	protected override void Start()
	{
	}

	public override void Setup(Action<UI_LazyListItem<ChatEntry>> inOnClicked, Action<UI_LazyListItem<ChatEntry>> inOnSelected, ChatEntry inData, UI_LazyItemList<ChatEntry> inItemList)
	{
	}

	private void OnChatDisplayDataChanged(ChatEntry.ChatDisplayData inDisplayData)
	{
	}

	public void SetTextSize(int inTextSize)
	{
	}

	private void RefreshText()
	{
	}

	private void OnDisable()
	{
	}
}
