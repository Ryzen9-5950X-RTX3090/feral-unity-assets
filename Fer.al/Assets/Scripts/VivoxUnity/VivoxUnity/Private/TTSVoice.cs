using System.ComponentModel;
using System.Runtime.CompilerServices;
using VivoxUnity.Properties;

namespace VivoxUnity.Private
{
	internal class TTSVoice : ITTSVoice, IKeyedItemNotifyPropertyChanged<uint>, INotifyPropertyChanged
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

		public uint Key
		{
			[CompilerGenerated]
			get
			{
				return default(uint);
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

		internal TTSVoice(vx_tts_voice_t voice)
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		protected bool Equals(TTSVoice other)
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
