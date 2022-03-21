using UnityEngine;

namespace Rewired.Platforms.PS4
{
	[CustomClassObfuscation]
	[CustomObfuscation]
	internal interface IPS4ControllerExtensionSource : IPS4ControllerExtensionSourceSixAxisSensor, IPS4ControllerExtensionSourceVibrator, IPS4ControllerExtensionSourceLight
	{
		int GetUserId();

		int GetUserStatus();

		bool GetUserIsPrimary();

		Color GetUserColor();

		int GetUserColorId();

		string GetUserName();
	}
}
