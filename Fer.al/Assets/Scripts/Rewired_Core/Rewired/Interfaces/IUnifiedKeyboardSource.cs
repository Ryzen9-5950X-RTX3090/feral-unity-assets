namespace Rewired.Interfaces
{
	[CustomObfuscation]
	[CustomClassObfuscation]
	internal interface IUnifiedKeyboardSource
	{
		InputSource inputSource { get; }

		HardwareControllerMap_Game hardwareMap { get; }

		int buttonCount { get; }

		void UpdateInputData(ControllerDataUpdater dataUpdater);

		void Clear();
	}
}
