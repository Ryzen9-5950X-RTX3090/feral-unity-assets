using System;
using System.ComponentModel;
using System.Runtime.InteropServices;
using UnityEngine;

namespace VivoxUnity
{
	public interface IChannelSession : IKeyedItemNotifyPropertyChanged<ChannelId>, INotifyPropertyChanged
	{
		string SessionHandle { get; }

		ILoginSession Parent { get; }

		ConnectionState AudioState { get; }

		ConnectionState TextState { get; }

		ConnectionState ChannelState { get; }

		IReadOnlyDictionary<string, IParticipant> Participants { get; }

		[Obsolete]
		bool Typing { get; set; }

		IReadOnlyQueue<IChannelTextMessage> MessageLog { get; }

		IReadOnlyQueue<ISessionArchiveMessage> SessionArchive { get; }

		IArchiveQueryResult SessionArchiveResult { get; }

		IReadOnlyQueue<ITranscribedMessage> TranscribedLog { get; }

		bool IsTransmitting { get; }

		bool IsSessionBeingTranscribed { get; }

		ChannelId Channel { get; }

		IAsyncResult BeginConnect(bool connectAudio, bool connectText, bool switchTransmission, string accessToken, AsyncCallback callback);

		void EndConnect(IAsyncResult result);

		IAsyncResult Disconnect([Optional] AsyncCallback callback);

		IAsyncResult BeginSetAudioConnected(bool value, bool switchTransmission, AsyncCallback callback);

		void EndSetAudioConnected(IAsyncResult result);

		IAsyncResult BeginSetTextConnected(bool value, AsyncCallback callback);

		void EndSetTextConnected(IAsyncResult result);

		IAsyncResult BeginSendText(string message, AsyncCallback callback);

		IAsyncResult BeginSendText(string language, string message, string applicationStanzaNamespace, string applicationStanzaBody, AsyncCallback callback);

		void EndSendText(IAsyncResult result);

		IAsyncResult BeginSessionArchiveQuery(DateTime? timeStart, DateTime? timeEnd, string searchText, AccountId userId, uint max, string afterId, string beforeId, int firstMessageIndex, AsyncCallback callback);

		void EndSessionArchiveQuery(IAsyncResult result);

		string GetConnectToken(string tokenSigningKey, TimeSpan tokenExpirationDuration);

		void Set3DPosition(Vector3 speakerPos, Vector3 listenerPos, Vector3 listenerAtOrient, Vector3 listenerUpOrient);

		IAsyncResult BeginSetChannelTranscription(bool value, string accessToken, AsyncCallback callback);

		void EndSetChannelTranscription(IAsyncResult result);

		string GetTranscriptionToken(string tokenSigningKey, TimeSpan tokenExpirationDuration);
	}
}
