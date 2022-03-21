using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using VivoxUnity;

public class VivoxVoiceManager : MonoBehaviour
{
	public enum ChangedProperty
	{
		None,
		Speaking,
		Typing,
		Muted
	}

	public enum ChatCapability
	{
		TextOnly,
		AudioOnly,
		TextAndAudio
	}

	public delegate void ParticipantValueChangedHandler(string username, ChannelId channel, bool value);

	public delegate void ParticipantValueUpdatedHandler(string username, ChannelId channel, double value);

	public delegate void ParticipantStatusChangedHandler(string username, ChannelId channel, IParticipant participant);

	public delegate void ChannelTextMessageChangedHandler(string sender, IChannelTextMessage channelTextMessage);

	public delegate void LoginStatusChangedHandler();

	[SerializeField]
	private string _server;

	[SerializeField]
	private string _domain;

	[SerializeField]
	private string _tokenIssuer;

	[SerializeField]
	private string _tokenKey;

	private TimeSpan _tokenExpiration;

	private Client _client;

	private AccountId _accountId;

	private static object m_Lock;

	private static VivoxVoiceManager m_Instance;

	public ILoginSession LoginSession;

	private Uri _serverUri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public static VivoxVoiceManager Instance
	{
		get
		{
			return null;
		}
	}

	public LoginState LoginState
	{
		[CompilerGenerated]
		get
		{
			return default(LoginState);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public IReadOnlyDictionary<ChannelId, IChannelSession> ActiveChannels
	{
		get
		{
			return null;
		}
	}

	public IAudioDevices AudioInputDevices
	{
		get
		{
			return null;
		}
	}

	public IAudioDevices AudioOutputDevices
	{
		get
		{
			return null;
		}
	}

	public IChannelSession TransmittingSession
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public event ParticipantValueChangedHandler OnSpeechDetectedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event ParticipantValueUpdatedHandler OnAudioEnergyChangedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event ParticipantStatusChangedHandler OnParticipantAddedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event ParticipantStatusChangedHandler OnParticipantRemovedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event ChannelTextMessageChangedHandler OnTextMessageLogReceivedEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event LoginStatusChangedHandler OnUserLoggedInEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	public event LoginStatusChangedHandler OnUserLoggedOutEvent
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private void Awake()
	{
	}

	private void Start()
	{
	}

	private void OnApplicationQuit()
	{
	}

	public void Login([Optional] string displayName)
	{
	}

	public void Logout()
	{
	}

	public void JoinChannel(string channelName, ChannelType channelType, ChatCapability chatCapability, bool switchTransmission = true, [Optional] Channel3DProperties properties)
	{
	}

	public void SendTextMessage(string messageToSend, ChannelId channel, [Optional] string applicationStanzaNamespace, [Optional] string applicationStanzaBody)
	{
	}

	public void DisconnectAllChannels()
	{
	}

	private void OnMessageLogRecieved(object sender, QueueItemAddedEventArgs<IChannelTextMessage> textMessage)
	{
	}

	private void OnLoginSessionPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
	{
	}

	private void OnParticipantAdded(object sender, KeyEventArg<string> keyEventArg)
	{
	}

	private void OnParticipantRemoved(object sender, KeyEventArg<string> keyEventArg)
	{
	}

	private static void ValidateArgs(object[] objs)
	{
	}

	private void OnParticipantValueUpdated(object sender, ValueEventArg<string, IParticipant> valueEventArg)
	{
	}

	private void OnChannelPropertyChanged(object sender, PropertyChangedEventArgs propertyChangedEventArgs)
	{
	}

	private void VivoxLog(string msg)
	{
	}

	private void VivoxLogError(string msg)
	{
	}
}
