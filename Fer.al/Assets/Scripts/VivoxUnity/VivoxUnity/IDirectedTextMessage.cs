using System.ComponentModel;

namespace VivoxUnity
{
	public interface IDirectedTextMessage : ITextMessage, IKeyedItemNotifyPropertyChanged<string>, INotifyPropertyChanged
	{
		ILoginSession LoginSession { get; }

		AccountId Sender { get; }

		string ApplicationStanzaNamespace { get; }

		string ApplicationStanzaBody { get; }
	}
}
