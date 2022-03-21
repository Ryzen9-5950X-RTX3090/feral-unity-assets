using System;
using Rewired.Interfaces;

namespace Rewired
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal class UnityUnifiedKeyboardSource : IDisposable, IUnifiedKeyboardSource
	{
		private const int dkbQwWEGdYvWqHgwDVFfqiIBuCI = 132;

		private static HardwareControllerMap_Game qGQYerJXPeWtuzKISCxSYKrxjAn;

		private bool vEblpmllYIOuQHCXVghuIpihdSG;

		public InputSource inputSource
		{
			get
			{
				return default(InputSource);
			}
		}

		public HardwareControllerMap_Game hardwareMap
		{
			get
			{
				return null;
			}
		}

		public int buttonCount
		{
			get
			{
				return default(int);
			}
		}

		public void UpdateInputData(ControllerDataUpdater dataUpdater)
		{
		}

		public void Clear()
		{
		}

		private static HardwareControllerMap_Game ucxBBbNIZPrkEAlWZbXBqgYqHGL()
		{
			return null;
		}

		public void Dispose()
		{
		}

		~UnityUnifiedKeyboardSource()
		{
		}

		protected virtual void Dispose(bool disposing)
		{
		}

		public static ControllerElementType GetHardwareElementType(int elementIdentifierId)
		{
			return default(ControllerElementType);
		}
	}
}
