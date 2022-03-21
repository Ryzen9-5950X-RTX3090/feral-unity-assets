using System.Collections.ObjectModel;
using System.ComponentModel;

namespace VivoxUnity
{
	public interface ITextToSpeech : INotifyPropertyChanged
	{
		ReadOnlyCollection<ITTSVoice> AvailableVoices { get; }

		ITTSVoice CurrentVoice { get; set; }

		ITTSMessageQueue Messages { get; }

		void Speak(TTSMessage message);

		void CancelMessage(TTSMessage message);

		void CancelDestination(TTSDestination destination);

		void CancelAll();

		ReadOnlyCollection<TTSMessage> GetMessagesFromDestination(TTSDestination destination);
	}
}
