using System;
using Rewired.Interfaces;

namespace Rewired
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal class UpdateControllerInfoEventArgs : EventArgs
	{
		public readonly IInputManagerJoystickPublic sourceJoystick;

		public UpdateControllerInfoEventArgs(IInputManagerJoystickPublic sourceJoystick)
		{
		}
	}
}
