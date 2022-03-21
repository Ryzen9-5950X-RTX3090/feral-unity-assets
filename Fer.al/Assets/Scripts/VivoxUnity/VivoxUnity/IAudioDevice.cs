using System.ComponentModel;

namespace VivoxUnity
{
	public interface IAudioDevice : IKeyedItemNotifyPropertyChanged<string>, INotifyPropertyChanged
	{
		string Name { get; }
	}
}
