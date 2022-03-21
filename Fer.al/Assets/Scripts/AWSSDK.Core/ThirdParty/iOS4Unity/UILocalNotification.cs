using System;

namespace ThirdParty.iOS4Unity
{
	public class UILocalNotification : NSObject
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public string AlertAction
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string AlertBody
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string AlertLaunchImage
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string AlertTitle
		{
			get
			{
				return null;
			}
			set
			{
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

		public string Category
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public DateTime FireDate
		{
			get
			{
				return default(DateTime);
			}
			set
			{
			}
		}

		public bool HasAction
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public string SoundName
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public NSDictionary UserInfo
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		static UILocalNotification()
		{
		}

		public UILocalNotification()
		{
		}

		internal UILocalNotification(IntPtr handle)
		{
		}
	}
}
