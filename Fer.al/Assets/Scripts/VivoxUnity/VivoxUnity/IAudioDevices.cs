using System;
using System.ComponentModel;

namespace VivoxUnity
{
	public interface IAudioDevices : INotifyPropertyChanged
	{
		IAudioDevice SystemDevice { get; }

		IReadOnlyDictionary<string, IAudioDevice> AvailableDevices { get; }

		IAudioDevice ActiveDevice { get; }

		IAudioDevice EffectiveDevice { get; }

		int VolumeAdjustment { get; set; }

		bool Muted { get; set; }

		IAsyncResult BeginSetActiveDevice(IAudioDevice device, AsyncCallback callback);

		void EndSetActiveDevice(IAsyncResult result);

		IAsyncResult BeginRefresh(AsyncCallback cb);

		void EndRefresh(IAsyncResult result);
	}
}
