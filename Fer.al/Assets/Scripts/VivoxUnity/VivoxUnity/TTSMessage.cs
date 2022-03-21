using System.ComponentModel;
using System.Runtime.CompilerServices;
using VivoxUnity.Properties;

namespace VivoxUnity
{
	public sealed class TTSMessage
	{
		private readonly string _text;

		private readonly TTSDestination _destination;

		private ITTSVoice _voice;

		private TTSMessageState _state;

		private uint _numConsumers;

		private double _duration;

		private uint _key;

		private ITextToSpeech _ttsSubSystem;

		public string Text
		{
			get
			{
				return null;
			}
		}

		public TTSDestination Destination
		{
			get
			{
				return default(TTSDestination);
			}
		}

		public ITTSVoice Voice
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public TTSMessageState State
		{
			get
			{
				return default(TTSMessageState);
			}
			internal set
			{
			}
		}

		public uint NumConsumers
		{
			get
			{
				return default(uint);
			}
			internal set
			{
			}
		}

		public double Duration
		{
			get
			{
				return default(double);
			}
			internal set
			{
			}
		}

		internal uint Key
		{
			get
			{
				return default(uint);
			}
			set
			{
			}
		}

		internal ITextToSpeech TTS
		{
			get
			{
				return null;
			}
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

		public TTSMessage(string text, TTSDestination destination)
		{
		}

		public void Speak(ILoginSession userSpeaking)
		{
		}

		public void Cancel()
		{
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		private bool Equals(TTSMessage other)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		[NotifyPropertyChangedInvocator]
		private void OnPropertyChanged(string propertyName)
		{
		}

		internal bool AlreadySpoken()
		{
			return default(bool);
		}
	}
}
