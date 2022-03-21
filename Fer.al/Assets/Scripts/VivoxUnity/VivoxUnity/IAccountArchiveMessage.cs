using System.ComponentModel;

namespace VivoxUnity
{
	public interface IAccountArchiveMessage : ITextMessage, IKeyedItemNotifyPropertyChanged<string>, INotifyPropertyChanged
	{
		ILoginSession LoginSession { get; }

		string QueryId { get; }

		AccountId RemoteParticipant { get; }

		ChannelId Channel { get; }

		bool Inbound { get; }

		string MessageId { get; }
	}
}
