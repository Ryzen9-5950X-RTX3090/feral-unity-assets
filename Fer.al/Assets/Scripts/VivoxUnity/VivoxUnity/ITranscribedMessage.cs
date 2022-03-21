using System.ComponentModel;

namespace VivoxUnity
{
	public interface ITranscribedMessage : ITextMessage, IKeyedItemNotifyPropertyChanged<string>, INotifyPropertyChanged
	{
		IChannelSession ChannelSession { get; }

		AccountId Sender { get; }

		bool FromSelf { get; }
	}
}
