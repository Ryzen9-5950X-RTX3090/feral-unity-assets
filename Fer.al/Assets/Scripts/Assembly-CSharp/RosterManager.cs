using System.Collections.Generic;
using UnityEngine;
using VivoxUnity;

public class RosterManager : MonoBehaviour
{
	private const string LobbyChannelName = "lobbyChannel";

	private VivoxVoiceManager _vivoxVoiceManager;

	private Dictionary<ChannelId, List<RosterItem>> rosterObjects;

	public GameObject rosterItemPrefab;

	private void Start()
	{
	}

	private void Awake()
	{
	}

	private void OnDestroy()
	{
	}

	public void ClearAllRosters()
	{
	}

	public void ClearChannelRoster(ChannelId channel)
	{
	}

	private void CleanRoster(ChannelId channel)
	{
	}

	private void OnChannelDisconnected(ChannelId channel, ConnectionState audioConnectionState)
	{
	}

	private void OnUserLoggedOut()
	{
	}

	private void UpdateParticipantRoster(IParticipant participant, ChannelId channel, bool isAddParticipant)
	{
	}

	private void OnParticipantAdded(string userName, ChannelId channel, IParticipant participant)
	{
	}

	private void OnParticipantRemoved(string userName, ChannelId channel, IParticipant participant)
	{
	}
}
