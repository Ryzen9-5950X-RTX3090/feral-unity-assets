using TMPro;
using UnityEngine;

public class UI_UnreadConversationCount : MonoBehaviour
{
	[SerializeField]
	private WWTextMeshProUGUI _unreadCountText;

	[SerializeField]
	private FeralAudioInfo _unreadAudioInfo;

	private void Start()
	{
	}

	private void OnDestroy()
	{
	}

	private void OnConversationReadStateChanged(ConversationReadStateChangedMessage inMessage)
	{
	}

	private void RefreshText(int inUnreadCount)
	{
	}
}
