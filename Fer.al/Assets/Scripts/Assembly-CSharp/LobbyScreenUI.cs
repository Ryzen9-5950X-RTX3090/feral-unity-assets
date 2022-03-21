using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using VivoxUnity;

public class LobbyScreenUI : MonoBehaviour
{
	private VivoxVoiceManager _vivoxVoiceManager;

	public string LobbyChannelName;

	private EventSystem _evtSystem;

	public Button LogoutButton;

	public GameObject LobbyScreen;

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	private void JoinLobbyChannel()
	{
	}

	private void LogoutOfVivoxService()
	{
	}

	private void VivoxVoiceManager_OnParticipantAddedEvent(string username, ChannelId channel, IParticipant participant)
	{
	}

	private void OnUserLoggedIn()
	{
	}

	private void OnUserLoggedOut()
	{
	}
}
