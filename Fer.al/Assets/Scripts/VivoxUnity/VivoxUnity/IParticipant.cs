using System;
using System.ComponentModel;

namespace VivoxUnity
{
	public interface IParticipant : IKeyedItemNotifyPropertyChanged<string>, INotifyPropertyChanged, IParticipantProperties
	{
		string ParticipantId { get; }

		IChannelSession ParentChannelSession { get; }

		AccountId Account { get; }

		IAsyncResult SetIsMuteForAll(string accountHandle, bool setMuted, string accessToken, AsyncCallback callback);
	}
}
