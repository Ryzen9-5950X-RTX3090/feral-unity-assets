using System.ComponentModel;

namespace VivoxUnity
{
	public interface ITTSVoice : IKeyedItemNotifyPropertyChanged<uint>, INotifyPropertyChanged
	{
		string Name { get; }
	}
}
