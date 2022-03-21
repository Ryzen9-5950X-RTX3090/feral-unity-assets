using System;

namespace ThirdParty.iOS4Unity
{
	public class UIActionSheet : UIView
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
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

		public bool Visible
		{
			get
			{
				return default(bool);
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

		static UIActionSheet()
		{
		}

		public UIActionSheet()
		{
		}

		internal UIActionSheet(IntPtr handle)
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

		public void DismissWithClickedButtonIndex(int buttonIndex, bool animated)
		{
		}

		public void ShowInView(UIView view)
		{
		}
	}
}
