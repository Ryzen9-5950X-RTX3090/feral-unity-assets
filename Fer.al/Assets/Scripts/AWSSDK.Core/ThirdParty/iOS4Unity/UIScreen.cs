using System;

namespace ThirdParty.iOS4Unity
{
	public class UIScreen : NSObject
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public CGRect ApplicationFrame
		{
			get
			{
				return default(CGRect);
			}
		}

		public UIScreenMode[] AvailableModes
		{
			get
			{
				return null;
			}
		}

		public CGRect Bounds
		{
			get
			{
				return default(CGRect);
			}
		}

		public float Brightness
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public static string BrightnessDidChangeNotification
		{
			get
			{
				return null;
			}
		}

		public UIScreenMode CurrentMode
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public static string DidConnectNotification
		{
			get
			{
				return null;
			}
		}

		public static string DidDisconnectNotification
		{
			get
			{
				return null;
			}
		}

		public static UIScreen MainScreen
		{
			get
			{
				return null;
			}
		}

		public UIScreen MirroredScreen
		{
			get
			{
				return null;
			}
		}

		public static string ModeDidChangeNotification
		{
			get
			{
				return null;
			}
		}

		public CGRect NativeBounds
		{
			get
			{
				return default(CGRect);
			}
		}

		public float NativeScale
		{
			get
			{
				return default(float);
			}
		}

		public UIScreenMode PreferredMode
		{
			get
			{
				return null;
			}
		}

		public float Scale
		{
			get
			{
				return default(float);
			}
		}

		public static UIScreen[] Screens
		{
			get
			{
				return null;
			}
		}

		public bool WantsSoftwareDimming
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		static UIScreen()
		{
		}

		internal UIScreen(IntPtr handle)
		{
		}
	}
}
