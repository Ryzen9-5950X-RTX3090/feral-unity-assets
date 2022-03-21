using System;

namespace ThirdParty.iOS4Unity
{
	public sealed class UIDevice : NSObject
	{
		private static readonly IntPtr _classHandle;

		private static int _majorVersion;

		private static int _minorVersion;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public static string BatteryLevelDidChangeNotification
		{
			get
			{
				return null;
			}
		}

		public static string BatteryStateDidChangeNotification
		{
			get
			{
				return null;
			}
		}

		public static string OrientationDidChangeNotification
		{
			get
			{
				return null;
			}
		}

		public static string ProximityStateDidChangeNotification
		{
			get
			{
				return null;
			}
		}

		public static UIDevice CurrentDevice
		{
			get
			{
				return null;
			}
		}

		public float BatteryLevel
		{
			get
			{
				return default(float);
			}
		}

		public bool BatteryMonitoringEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public UIDeviceBatteryState BatteryState
		{
			get
			{
				return default(UIDeviceBatteryState);
			}
		}

		public bool GeneratesDeviceOrientationNotifications
		{
			get
			{
				return default(bool);
			}
		}

		public string LocalizedModel
		{
			get
			{
				return null;
			}
		}

		public string Model
		{
			get
			{
				return null;
			}
		}

		public string Name
		{
			get
			{
				return null;
			}
		}

		public UIDeviceOrientation Orientation
		{
			get
			{
				return default(UIDeviceOrientation);
			}
		}

		public bool ProximityMonitoringEnabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool ProximityState
		{
			get
			{
				return default(bool);
			}
		}

		public string SystemName
		{
			get
			{
				return null;
			}
		}

		public string SystemVersion
		{
			get
			{
				return null;
			}
		}

		public UIUserInterfaceIdiom UserInterfaceIdiom
		{
			get
			{
				return default(UIUserInterfaceIdiom);
			}
		}

		static UIDevice()
		{
		}

		internal UIDevice(IntPtr handle)
		{
		}

		public bool CheckSystemVersion(int major, int minor)
		{
			return default(bool);
		}

		public void PlayInputClick()
		{
		}
	}
}
