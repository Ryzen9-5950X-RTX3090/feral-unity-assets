using System;

namespace Rewired
{
	public abstract class ControllerWithMap : Controller
	{
		internal ControllerWithMap(int controllerId, InputSource inputSource, string name, string hardwareName, string hardwareIdentifier, ControllerType type, Guid hardwareTypeGuid, int buttonCount, bool[] isButtonPressureSensitive, HardwareControllerMap_Game hardwareMap, Extension extension, ControllerDataUpdater dataUpdater)
		{
		}
	}
}
