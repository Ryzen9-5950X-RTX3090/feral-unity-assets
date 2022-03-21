using System.ComponentModel;

namespace VivoxUnity
{
	public interface IKeyedItemNotifyPropertyChanged<out TK> : INotifyPropertyChanged
	{
		TK Key { get; }
	}
}
