using System;

namespace ThirdParty.iOS4Unity
{
	public class UIAlertView : NSObject
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public UIAlertViewStyle AlertViewStyle
		{
			get
			{
				return default(UIAlertViewStyle);
			}
			set
			{
			}
		}

		public int ButtonCount
		{
			get
			{
				return default(int);
			}
		}

		public int CancelButtonIndex
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public int FirstOtherButtonIndex
		{
			get
			{
				return default(int);
			}
		}

		public bool Visible
		{
			get
			{
				return default(bool);
			}
		}

		public string Message
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public string Title
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public event EventHandler<ButtonEventArgs> Clicked
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<ButtonEventArgs> Dismissed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<ButtonEventArgs> WillDismiss
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler Canceled
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler Presented
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler WillPresent
		{
			add
			{
			}
			remove
			{
			}
		}

		static UIAlertView()
		{
		}

		public UIAlertView()
		{
		}

		internal UIAlertView(IntPtr handle)
		{
		}

		public int AddButton(string title)
		{
			return default(int);
		}

		public string ButtonTitle(int index)
		{
			return null;
		}

		public void Show()
		{
		}

		public void Dismiss(int buttonIndex, bool animated = true)
		{
		}
	}
}
