using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Private
{
	internal class TextToSpeech : ITextToSpeech, INotifyPropertyChanged
	{
		private readonly Client _client;

		private List<ITTSVoice> _ttsAvailableVoices;

		private TTSVoice _ttsCurrentVoice;

		private readonly TTSMessageQueue _ttsMessages;

		public ReadOnlyCollection<ITTSVoice> AvailableVoices
		{
			get
			{
				return null;
			}
		}

		public ITTSVoice CurrentVoice
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public ITTSMessageQueue Messages
		{
			get
			{
				return null;
			}
		}

		internal uint TTSManagerId
		{
			get
			{
				return default(uint);
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

		internal TextToSpeech(Client client)
		{
		}

		~TextToSpeech()
		{
		}

		private void InstanceOnEventMessageReceived(vx_evt_base_t eventMessage)
		{
		}

		private void HandleTTSInjectionStarted(vx_evt_base_t eventMessage)
		{
		}

		private void HandleTTSInjectionEnded(vx_evt_base_t eventMessage)
		{
		}

		private void HandleTTSInjectionFailed(vx_evt_base_t eventMessage)
		{
		}

		public void Speak(TTSMessage message)
		{
		}

		public void CancelMessage(TTSMessage message)
		{
		}

		public void CancelDestination(TTSDestination destination)
		{
		}

		public void CancelAll()
		{
		}

		public ReadOnlyCollection<TTSMessage> GetMessagesFromDestination(TTSDestination destination)
		{
			return null;
		}

		internal bool TTSInitialize()
		{
			return default(bool);
		}

		internal static bool IsNotTTSError(vx_tts_status status)
		{
			return default(bool);
		}

		internal TTSMessage GetTTSMessageFromEvt(uint utteranceId)
		{
			return null;
		}

		internal void CleanupTTS()
		{
		}
	}
}
