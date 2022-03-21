namespace Rewired.Platforms.PS4
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal interface IPS4GamepadExtensionSource : IPS4ControllerExtensionSourceSixAxisSensor, IPS4ControllerExtensionSourceVibrator, IPS4ControllerExtensionSourceLight, IPS4ControllerExtensionSource, IPS4ControllerExtensionSourceTouchPad
	{
		int GetConnectionType();

		int GetAnalogDeadZoneLeft();

		int GetAnalogDeadZoneRight();
	}
}
