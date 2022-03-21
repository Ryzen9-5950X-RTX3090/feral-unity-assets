using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.UI;
using VivoxUnity;

public class TextChatUI : MonoBehaviour
{
	private VivoxVoiceManager _vivoxVoiceManager;

	private const string LobbyChannelName = "lobbyChannel";

	private ChannelId _lobbyChannelId;

	private List<GameObject> _messageObjPool;

	private ScrollRect _textChatScrollRect;

	public GameObject ChatContentObj;

	public GameObject MessageObject;

	public Button EnterButton;

	public Button SendTTSMessageButton;

	public InputField MessageInputField;

	public Toggle ToggleTTS;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void TTSToggleValueChanged(bool toggleTTS)
	{
	}

	private void ClearMessageObjectPool()
	{
	}

	private void ClearOutTextField()
	{
	}

	private void EnterKeyOnTextField()
	{
	}

	private void SubmitTextToVivox()
	{
	}

	public static string TruncateAtWord(string value, int length)
	{
		return null;
	}

	private void SubmitTTSMessageToVivox()
	{
	}

	[IteratorStateMachine(typeof(<SendScrollRectToBottom>d__20))]
	private IEnumerator SendScrollRectToBottom()
	{
		return null;
	}

	public void DisplayHostingMessage(IChannelTextMessage channelTextMessage)
	{
	}

	private void OnParticipantAdded(string username, ChannelId channel, IParticipant participant)
	{
	}

	private void OnTextMessageLogReceivedEvent(string sender, IChannelTextMessage channelTextMessage)
	{
	}
}
