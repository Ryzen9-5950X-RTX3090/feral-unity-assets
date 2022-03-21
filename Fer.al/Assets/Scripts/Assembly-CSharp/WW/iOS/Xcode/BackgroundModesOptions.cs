using System;

namespace WW.iOS.Xcode
{
	[Serializable]
	[Flags]
	public enum BackgroundModesOptions
	{
		None = 0,
		AudioAirplayPiP = 1,
		LocationUpdates = 2,
		VoiceOverIP = 4,
		NewsstandDownloads = 8,
		ExternalAccessoryCommunication = 0x10,
		UsesBluetoothLEAccessory = 0x20,
		ActsAsABluetoothLEAccessory = 0x40,
		BackgroundFetch = 0x80,
		RemoteNotifications = 0x100
	}
}
