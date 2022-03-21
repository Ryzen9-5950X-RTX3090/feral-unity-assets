using System;
using System.ComponentModel;

namespace VivoxUnity
{
	public interface ITextMessage : IKeyedItemNotifyPropertyChanged<string>, INotifyPropertyChanged
	{
		DateTime ReceivedTime { get; }

		string Message { get; }

		string Language { get; }
	}
}
