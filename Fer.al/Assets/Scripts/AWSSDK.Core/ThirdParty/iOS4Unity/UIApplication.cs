using System;
using System.Collections.Generic;

namespace ThirdParty.iOS4Unity
{
	public class UIApplication : NSObject
	{
		private static readonly IntPtr _classHandle;

		private Dictionary<object, IntPtrHandler2> _failed;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public static UIApplication SharedApplication
		{
			get
			{
				return null;
			}
		}

		public static string DidBecomeActiveNotification
		{
			get
			{
				return null;
			}
		}

		public static string DidEnterBackgroundNotification
		{
			get
			{
				return null;
			}
		}

		public static string DidFinishLaunchingNotification
		{
			get
			{
				return null;
			}
		}

		public static string DidReceiveMemoryWarningNotification
		{
			get
			{
				return null;
			}
		}

		public static string WillEnterForegroundNotification
		{
			get
			{
				return null;
			}
		}

		public static string WillResignActiveNotification
		{
			get
			{
				return null;
			}
		}

		public UIWindow KeyWindow
		{
			get
			{
				return null;
			}
		}

		public UIWindow[] Windows
		{
			get
			{
				return null;
			}
		}

		public int ApplicationIconBadgeNumber
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public UIApplicationState ApplicationState
		{
			get
			{
				return default(UIApplicationState);
			}
		}

		public UIStatusBarStyle StatusBarStyle
		{
			get
			{
				return default(UIStatusBarStyle);
			}
			set
			{
			}
		}

		public bool StatusBarHidden
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool NetworkActivityIndicatorVisible
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool IdleTimerDisabled
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		static UIApplication()
		{
		}

		internal UIApplication(IntPtr handle)
		{
		}

		public void SetStatusBarHidden(bool hidden, bool animated = true)
		{
		}

		public bool CanOpenUrl(string url)
		{
			return default(bool);
		}

		public bool OpenUrl(string url)
		{
			return default(bool);
		}

		public void RegisterForRemoteNotificationTypes(UIRemoteNotificationType types)
		{
		}

		public void UnregisterForRemoteNotifications()
		{
		}

		public void RegisterUserNotificationSettings(UIUserNotificationSettings notificationSettings)
		{
		}

		public void PresentLocationNotificationNow(UILocalNotification notification)
		{
		}

		public void ScheduleLocalNotification(UILocalNotification notification)
		{
		}

		public void CancelAllLocalNotifications()
		{
		}

		public void CancelLocalNotification(UILocalNotification notification)
		{
		}
	}
}
