using UnityEngine;
using UnityEngine.UI;

public class UI_ChatConversationList : MonoBehaviour
{
	[SerializeField]
	private UI_LazyItemList_ChatConversation _itemList;

	[SerializeField]
	private GameObject _chatInputGroup;

	[SerializeField]
	private FeralButton _emojiBtn;

	[SerializeField]
	private CanvasGroup _textSizeControl;

	private void Start()
	{
	}

	private void OnEnable()
	{
	}

	private void OnDisable()
	{
	}

	private void OnDestroy()
	{
	}

	private void Setup()
	{
	}

	private void OnConversationJoined(ChatConversationJoinedMessage inMessage)
	{
	}
}
