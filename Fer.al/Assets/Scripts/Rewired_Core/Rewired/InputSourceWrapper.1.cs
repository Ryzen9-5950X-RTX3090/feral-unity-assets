using System;
using System.Collections.Generic;
using Rewired.Interfaces;

namespace Rewired
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal class InputSourceWrapper<T> : IDisposable, IInputSource
	{
		private T JEVAvDAWidJhVxFUpAPvixPZmfz;

		private bool vEblpmllYIOuQHCXVghuIpihdSG;

		public T source
		{
			get
			{
				return (T)null;
			}
		}

		public event Action DeviceChangedEvent
		{
			add
			{
			}
			remove
			{
			}
		}

		public InputSourceWrapper(T source)
		{
		}

		public void SystemDeviceConnected()
		{
		}

		public void SystemDeviceDisconnected()
		{
		}

		public void Update()
		{
		}

		public void UpdateDevices(UpdateLoopType updateLoop)
		{
		}

		public void UpdateFinished()
		{
		}

		public IList<TJoy> GetJoysticks<TJoy>() where TJoy : class
		{
			return null;
		}

		public void Dispose()
		{
		}

		~InputSourceWrapper()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}
	}
}
