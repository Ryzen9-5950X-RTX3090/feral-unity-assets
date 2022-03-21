using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UI_ChatEmojiList : MonoBehaviour
{
	[SerializeField]
	private UI_ChatEmojiItem _emojiItem;

	[SerializeField]
	private Transform _emojiParent;

	[SerializeField]
	private TMP_InputField _chatInput;

	[SerializeField]
	private FeralButton _toggleEmojiBtn;

	private void Start()
	{
	}

	private void SpawnListItems()
	{
	}

	private void SpawnListItem(ChatEmojiDefComponent inEmoji)
	{
	}

	private void OnEmojiClicked(ChatEmojiDefComponent inEmoji)
	{
	}
}
