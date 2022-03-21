using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Private
{
	internal class PresenceLocation : IPresenceLocation, IKeyedItemNotifyPropertyChanged<string>, INotifyPropertyChanged
	{
		private Presence _currentPresence;

		private string _location;

		[CompilerGenerated]
		private readonly string <Key>k__BackingField;

		public string Key
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
		}

		public Presence CurrentPresence
		{
			get
			{
				return default(Presence);
			}
			set
			{
			}
		}

		public string Location
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public IPresenceSubscription Subscription
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

		public string LocationId
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

		public PresenceLocation(string key)
		{
		}
	}
}
