using Services.Chat;
using UnityEngine;

public class UI_ChatPanel_Conversations : MonoBehaviour
{
	[SerializeField]
	private CanvasGroup _conversationListGroup;

	[SerializeField]
	private CanvasGroup _messageListGroup;

	[SerializeField]
	private CanvasGroup _closeConversationButtonGroup;

	[SerializeField]
	private UI_ChatPanel_Private _privateChatPanel;

	[SerializeField]
	private UI_LazyItemList_ChatConversation _conversationItemList;

	private ChatConversationData _conversation;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	public void SetSelectedConversation(ChatConversationData inData, bool inFromSetup = false)
	{
	}

	public void BtnClicked_CloseConversation()
	{
	}

	public void BtnClicked_FindPlayer()
	{
	}

	private void OnConversationItemClicked(ChatConversationData inConversation)
	{
	}

	public void RecalculateLayout()
	{
	}
}
