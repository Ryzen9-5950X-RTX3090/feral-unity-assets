using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.InteropServices;

namespace VivoxUnity
{
	public interface ILoginSession : IKeyedItemNotifyPropertyChanged<AccountId>, INotifyPropertyChanged
	{
		IReadOnlyDictionary<ChannelId, IChannelSession> ChannelSessions { get; }

		IReadOnlyDictionary<AccountId, IPresenceSubscription> PresenceSubscriptions { get; }

		IReadOnlyHashSet<AccountId> BlockedSubscriptions { get; }

		IReadOnlyHashSet<AccountId> AllowedSubscriptions { get; }

		IReadOnlyQueue<AccountId> IncomingSubscriptionRequests { get; }

		IReadOnlyHashSet<AccountId> CrossMutedCommunications { get; }

		IReadOnlyQueue<IDirectedTextMessage> DirectedMessages { get; }

		IReadOnlyQueue<IFailedDirectedTextMessage> FailedDirectedMessages { get; }

		IReadOnlyQueue<IAccountArchiveMessage> AccountArchive { get; }

		IArchiveQueryResult AccountArchiveResult { get; }

		IDirectedMessageResult DirectedMessageResult { get; }

		LoginState State { get; }

		TransmissionMode TransmissionType { get; }

		ReadOnlyCollection<ChannelId> TransmittingChannels { get; }

		bool IsInjectingAudio { get; }

		Presence Presence { get; set; }

		AccountId LoginSessionId { get; }

		ParticipantPropertyUpdateFrequency ParticipantPropertyFrequency { get; set; }

		ITextToSpeech TTS { get; }

		IAsyncResult BeginLogin(Uri server, string accessToken, SubscriptionMode subscriptionMode, IReadOnlyHashSet<AccountId> presenceSubscriptions, IReadOnlyHashSet<AccountId> blockedPresenceSubscriptions, IReadOnlyHashSet<AccountId> allowedPresenceSubscriptions, AsyncCallback callback);

		IAsyncResult BeginLogin(Uri server, string accessToken, AsyncCallback callback);

		void EndLogin(IAsyncResult result);

		IAsyncResult BeginAccountSetLoginProperties(ParticipantPropertyUpdateFrequency participantPropertyFrequency, AsyncCallback callback);

		void EndAccountSetLoginProperties(IAsyncResult result);

		IChannelSession GetChannelSession(ChannelId channelId);

		void DeleteChannelSession(ChannelId channelId);

		IAsyncResult BeginAddBlockedSubscription(AccountId accountId, AsyncCallback callback);

		void EndAddBlockedSubscription(IAsyncResult result);

		IAsyncResult BeginRemoveBlockedSubscription(AccountId accountId, AsyncCallback callback);

		void EndRemoveBlockedSubscription(IAsyncResult result);

		IAsyncResult BeginAddAllowedSubscription(AccountId accountId, AsyncCallback callback);

		void EndAddAllowedSubscription(IAsyncResult result);

		IAsyncResult BeginRemoveAllowedSubscription(AccountId accountId, AsyncCallback callback);

		void EndRemoveAllowedSubscription(IAsyncResult result);

		IAsyncResult BeginAddPresenceSubscription(AccountId accountId, AsyncCallback callback);

		IPresenceSubscription EndAddPresenceSubscription(IAsyncResult result);

		IAsyncResult BeginRemovePresenceSubscription(AccountId accountId, AsyncCallback callback);

		void EndRemovePresenceSubscription(IAsyncResult result);

		IAsyncResult BeginSendDirectedMessage(AccountId accountId, string language, string message, string applicationStanzaNamespace, string applicationStanzaBody, AsyncCallback callback);

		IAsyncResult BeginSendDirectedMessage(AccountId accountId, string message, AsyncCallback callback);

		void EndSendDirectedMessage(IAsyncResult result);

		IAsyncResult BeginAccountArchiveQuery(DateTime? timeStart, DateTime? timeEnd, string searchText, AccountId userId, ChannelId channel, uint max, string afterId, string beforeId, int firstMessageIndex, AsyncCallback callback);

		void EndAccountArchiveQuery(IAsyncResult result);

		void SetTransmissionMode(TransmissionMode mode, [Optional] ChannelId singleChannel);

		void Logout();

		string GetLoginToken(string tokenSigningKey, TimeSpan tokenExpirationDuration);

		void StartAudioInjection(string audioFilePath);

		void StopAudioInjection();

		IAsyncResult SetCrossMutedCommunications(AccountId accountId, bool muted, AsyncCallback callback);

		IAsyncResult SetCrossMutedCommunications(List<AccountId> accountIdSet, bool muted, AsyncCallback callback);

		IAsyncResult ClearCrossMutedCommunications(AsyncCallback callback);
	}
}
