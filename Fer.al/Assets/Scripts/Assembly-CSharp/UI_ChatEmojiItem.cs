using System;
using TMPro;
using UnityEngine;

public class UI_ChatEmojiItem : MonoBehaviour
{
	[SerializeField]
	private WWTextMeshProUGUI _text;

	[SerializeField]
	private UI_Tooltip _tooltip;

	private ChatEmojiDefComponent _emoji;

	private Action<ChatEmojiDefComponent> _onClickedAction;

	public void Setup(ChatEmojiDefComponent inEmoji, Action<ChatEmojiDefComponent> inOnClickedAction)
	{
	}

	public void BtnClicked_Emoji()
	{
	}
}
