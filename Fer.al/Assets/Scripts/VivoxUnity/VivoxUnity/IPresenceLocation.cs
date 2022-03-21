using System.ComponentModel;

namespace VivoxUnity
{
	public interface IPresenceLocation : IKeyedItemNotifyPropertyChanged<string>, INotifyPropertyChanged
	{
		string LocationId { get; }

		Presence CurrentPresence { get; }

		IPresenceSubscription Subscription { get; }
	}
}
