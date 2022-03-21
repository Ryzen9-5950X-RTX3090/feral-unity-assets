using System;
using Rewired.Interfaces;
using Rewired.Platforms.Custom;

namespace Rewired
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal class BridgedController : BridgedControllerHWInfo
	{
		public IInputManagerJoystickPublic sourceJoystick;

		public HardwareControllerMap_Game gameHardwareMap;

		public Guid controllerTypeGuid;

		public Controller.Extension controllerExtension;

		public string instanceName;

		public string productName;

		public bool isXInputDevice;

		public int axisCount;

		public int buttonCount;

		public bool[] isButtonPressureSensitive;

		public UnknownControllerHat[] unknownControllerHats;

		public CustomInputSource customInputSource;

		public bool isUnknownController
		{
			get
			{
				return default(bool);
			}
		}
	}
}
