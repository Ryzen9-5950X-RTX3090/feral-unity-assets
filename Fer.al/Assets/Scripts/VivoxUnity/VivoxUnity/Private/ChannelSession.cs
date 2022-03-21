using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;
using VivoxUnity.Common;

namespace VivoxUnity.Private
{
	internal class ChannelSession : IChannelSession, IKeyedItemNotifyPropertyChanged<ChannelId>, INotifyPropertyChanged
	{
		private readonly LoginSession _loginSession;

		private readonly string _sessionHandle;

		private bool _typing;

		private bool _isSessionBeingTranscribed;

		private readonly ReadWriteDictionary<string, IParticipant, ChannelParticipant> _participants;

		private readonly ReadWriteQueue<IChannelTextMessage> _messageLog;

		private readonly ReadWriteQueue<ISessionArchiveMessage> _sessionArchive;

		private readonly ReadWriteQueue<ITranscribedMessage> _transcribedLog;

		private ArchiveQueryResult _sessionArchiveResult;

		private ConnectionState _audioState;

		private ConnectionState _textState;

		private ConnectionState _channelState;

		private int _nextTextId;

		private int _nextTranscriptiontId;

		private bool _deleted;

		[CompilerGenerated]
		private readonly string <GroupId>k__BackingField;

		[CompilerGenerated]
		private readonly ChannelId <Key>k__BackingField;

		public string SessionHandle
		{
			get
			{
				return null;
			}
		}

		public ILoginSession Parent
		{
			get
			{
				return null;
			}
		}

		public string GroupId
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public ChannelId Key
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public ConnectionState AudioState
		{
			get
			{
				return default(ConnectionState);
			}
			private set
			{
			}
		}

		public ConnectionState TextState
		{
			get
			{
				return default(ConnectionState);
			}
			set
			{
			}
		}

		public ConnectionState ChannelState
		{
			get
			{
				return default(ConnectionState);
			}
			set
			{
			}
		}

		public IReadOnlyDictionary<string, IParticipant> Participants
		{
			get
			{
				return null;
			}
		}

		public bool Typing
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public IReadOnlyQueue<IChannelTextMessage> MessageLog
		{
			get
			{
				return null;
			}
		}

		public IReadOnlyQueue<ITranscribedMessage> TranscribedLog
		{
			get
			{
				return null;
			}
		}

		public IReadOnlyQueue<ISessionArchiveMessage> SessionArchive
		{
			get
			{
				return null;
			}
		}

		public IArchiveQueryResult SessionArchiveResult
		{
			get
			{
				return null;
			}
		}

		public bool IsTransmitting
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsSessionBeingTranscribed
		{
			get
			{
				return default(bool);
			}
		}

		public ChannelId Channel
		{
			get
			{
				return null;
			}
		}

		public event PropertyChangedEventHandler PropertyChanged
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

		private bool AlreadyDone(bool connect, ConnectionState state)
		{
			return default(bool);
		}

		private void AssertSessionNotDeleted()
		{
		}

		private void CheckSessionConnection()
		{
		}

		public ChannelSession(LoginSession loginSession, ChannelId channelId, string groupId)
		{
		}

		private void InstanceOnEventMessageReceived(vx_evt_base_t eventMessage)
		{
		}

		private void HandleParticipantAdded(vx_evt_base_t eventMessage)
		{
		}

		private void HandleParticipantRemoved(vx_evt_base_t eventMessage)
		{
		}

		private void HandleParticipantUpdated(vx_evt_base_t eventMessage)
		{
		}

		private void HandleMediaStreamUpdated(vx_evt_base_t eventMessage)
		{
		}

		private void HandleTextStreamUpdated(vx_evt_base_t eventMessage)
		{
		}

		private void HandleSessionRemoved(vx_evt_base_t eventMessage)
		{
		}

		private void HandleSessionMessage(vx_evt_base_t eventMessage)
		{
		}

		private void HandleSessionArchiveMessage(vx_evt_base_t eventMessage)
		{
		}

		private void HandleSessionArchiveQueryEnd(vx_evt_base_t eventMessage)
		{
		}

		private void HandleSessionTranscribedMessage(vx_evt_base_t eventMessage)
		{
		}

		public IAsyncResult BeginConnect(bool connectAudio, bool connectText, bool switchTransmission, string accessToken, AsyncCallback callback)
		{
			return null;
		}

		public void EndConnect(IAsyncResult ar)
		{
		}

		public IAsyncResult Disconnect([Optional] AsyncCallback callback)
		{
			return null;
		}

		public IAsyncResult BeginSetAudioConnected(bool value, bool switchTransmission, AsyncCallback callback)
		{
			return null;
		}

		public void EndSetAudioConnected(IAsyncResult result)
		{
		}

		public IAsyncResult BeginSetTextConnected(bool value, AsyncCallback callback)
		{
			return null;
		}

		public void EndSetTextConnected(IAsyncResult result)
		{
		}

		public IAsyncResult BeginSendText(string message, AsyncCallback callback)
		{
			return null;
		}

		public IAsyncResult BeginSendText(string language, string message, string applicationStanzaNamespace, string applicationStanzaBody, AsyncCallback callback)
		{
			return null;
		}

		public void EndSendText(IAsyncResult result)
		{
		}

		public IAsyncResult BeginSessionArchiveQuery(DateTime? timeStart, DateTime? timeEnd, string searchText, AccountId userId, uint max, string afterId, string beforeId, int firstMessageIndex, AsyncCallback callback)
		{
			return null;
		}

		public void EndSessionArchiveQuery(IAsyncResult result)
		{
		}

		public string GetConnectToken(string key, TimeSpan expiration)
		{
			return null;
		}

		public IAsyncResult BeginSetChannelTranscription(bool value, string accessToken, AsyncCallback callback)
		{
			return null;
		}

		public void EndSetChannelTranscription(IAsyncResult result)
		{
		}

		public string GetTranscriptionToken(string tokenSigningKey, TimeSpan tokenExpirationDuration)
		{
			return null;
		}

		public void Set3DPosition(Vector3 speakerPos, Vector3 listenerPos, Vector3 listenerAtOrient, Vector3 listenerUpOrient)
		{
		}

		public void Delete()
		{
		}
	}
}
