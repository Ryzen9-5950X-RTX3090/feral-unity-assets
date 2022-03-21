using System.ComponentModel;
using System.Runtime.CompilerServices;
using VivoxUnity.Properties;

namespace VivoxUnity.Private
{
	internal class AudioDevice : IAudioDevice, IKeyedItemNotifyPropertyChanged<string>, INotifyPropertyChanged
	{
		public string Name
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

		public string Key
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

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		protected bool Equals(AudioDevice other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		[NotifyPropertyChangedInvocator]
		protected virtual void OnPropertyChanged(string propertyName)
		{
		}
	}
}
