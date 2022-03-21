using System.ComponentModel;

namespace VivoxUnity
{
	public interface ISessionArchiveMessage : ITextMessage, IKeyedItemNotifyPropertyChanged<string>, INotifyPropertyChanged
	{
		IChannelSession ChannelSession { get; }

		AccountId Sender { get; }

		bool FromSelf { get; }

		string QueryId { get; }

		string MessageId { get; }
	}
}
