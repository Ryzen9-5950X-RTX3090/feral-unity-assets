using System.ComponentModel;
using System.Runtime.CompilerServices;
using VivoxUnity.Common;

namespace VivoxUnity.Private
{
	internal class PresenceSubscription : IPresenceSubscription, IKeyedItemNotifyPropertyChanged<AccountId>, INotifyPropertyChanged
	{
		private readonly ReadWriteDictionary<string, IPresenceLocation, PresenceLocation> _locations;

		public AccountId Key
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public IReadOnlyDictionary<string, IPresenceLocation> Locations
		{
			get
			{
				return null;
			}
		}

		public AccountId SubscribedAccount
		{
			get
			{
				return null;
			}
		}

		public event PropertyChangedEventHandler PropertyChanged
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void UpdateLocation(string uriWithTag, PresenceStatus status, string message)
		{
		}
	}
}
