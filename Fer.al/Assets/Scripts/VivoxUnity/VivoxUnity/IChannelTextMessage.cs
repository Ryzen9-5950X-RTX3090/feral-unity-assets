using System.ComponentModel;

namespace VivoxUnity
{
	public interface IChannelTextMessage : ITextMessage, IKeyedItemNotifyPropertyChanged<string>, INotifyPropertyChanged
	{
		IChannelSession ChannelSession { get; }

		AccountId Sender { get; }

		bool FromSelf { get; }

		string ApplicationStanzaNamespace { get; }

		string ApplicationStanzaBody { get; }
	}
}
