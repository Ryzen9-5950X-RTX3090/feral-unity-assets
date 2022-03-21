using System;

namespace ThirdParty.iOS4Unity
{
	public class UIUserNotificationSettings : NSObject
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public UIUserNotificationType Types
		{
			get
			{
				return default(UIUserNotificationType);
			}
		}

		static UIUserNotificationSettings()
		{
		}

		public UIUserNotificationSettings()
		{
		}

		internal UIUserNotificationSettings(IntPtr handle)
		{
		}

		public static UIUserNotificationSettings GetSettingsForTypes(UIUserNotificationType types)
		{
			return null;
		}
	}
}
