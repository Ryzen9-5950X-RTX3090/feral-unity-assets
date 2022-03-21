using System.ComponentModel;

namespace VivoxUnity
{
	public interface IPresenceSubscription : IKeyedItemNotifyPropertyChanged<AccountId>, INotifyPropertyChanged
	{
		AccountId SubscribedAccount { get; }

		IReadOnlyDictionary<string, IPresenceLocation> Locations { get; }
	}
}
