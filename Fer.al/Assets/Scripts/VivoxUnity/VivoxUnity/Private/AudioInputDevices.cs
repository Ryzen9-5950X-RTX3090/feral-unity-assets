using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using VivoxUnity.Common;

namespace VivoxUnity.Private
{
	internal class AudioInputDevices : IAudioDevices, INotifyPropertyChanged
	{
		private AudioDevice _systemDevice;

		private AudioDevice _communicationDevice;

		private AudioDevice _activeDevice;

		private AudioDevice _effectiveDevice;

		private int _audioGain;

		private bool _muted;

		private readonly VxClient _client;

		private readonly ReadWriteDictionary<string, IAudioDevice, AudioDevice> _devices;

		public IAudioDevice SystemDevice
		{
			get
			{
				return null;
			}
		}

		public IAudioDevice CommunicationDevice
		{
			get
			{
				return null;
			}
		}

		public IAudioDevice ActiveDevice
		{
			get
			{
				return null;
			}
		}

		public IAudioDevice EffectiveDevice
		{
			get
			{
				return null;
			}
		}

		public IReadOnlyDictionary<string, IAudioDevice> AvailableDevices
		{
			get
			{
				return null;
			}
		}

		public int VolumeAdjustment
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool Muted
		{
			get
			{
				return default(bool);
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

		private int ConvertGain(int gain)
		{
			return default(int);
		}

		public AudioInputDevices(VxClient client)
		{
		}

		public IAsyncResult BeginSetActiveDevice(IAudioDevice device, AsyncCallback callback)
		{
			return null;
		}

		public void EndSetActiveDevice(IAsyncResult result)
		{
		}

		public IAsyncResult BeginRefresh(AsyncCallback callback)
		{
			return null;
		}

		public void EndRefresh(IAsyncResult result)
		{
		}

		private void OnEventMessageReceived(vx_evt_base_t eventMessage)
		{
		}

		private void HandleDeviceHotSwap(vx_evt_base_t eventMessage)
		{
		}

		public void Clear()
		{
		}
	}
}
