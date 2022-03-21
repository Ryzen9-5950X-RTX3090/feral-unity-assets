namespace Rewired.Platforms.XboxOne
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal interface IXboxOneInputSource
	{
		int GetXboxOneUserIdFromUnityJoystick(int unityJoystickId);

		bool SetXboxOneVibration(ulong xboxOneJoystickId, xcWyiIfNoFqFVFpAfvXHnUTXXPi vibration);

		void PulseVibrateMotor(ulong xboxOneJoystickId, XboxOneGamepadMotorType motor, float startLevel, float endLevel, float duration);
	}
}
