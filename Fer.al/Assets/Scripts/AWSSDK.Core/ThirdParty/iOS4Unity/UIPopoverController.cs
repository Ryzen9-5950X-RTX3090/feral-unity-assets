using System;

namespace ThirdParty.iOS4Unity
{
	public class UIPopoverController : NSObject
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public UIViewController ContentViewController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public UIPopoverArrowDirection PopoverArrowDirection
		{
			get
			{
				return default(UIPopoverArrowDirection);
			}
		}

		public CGSize PopoverContentSize
		{
			get
			{
				return default(CGSize);
			}
			set
			{
			}
		}

		public bool PopoverVisible
		{
			get
			{
				return default(bool);
			}
		}

		public event EventHandler Dismissed
		{
			add
			{
			}
			remove
			{
			}
		}

		static UIPopoverController()
		{
		}

		public UIPopoverController(UIViewController controller)
		{
		}

		internal UIPopoverController(IntPtr handle)
		{
		}

		public void PresentFromRect(CGRect rect, UIView view, UIPopoverArrowDirection arrowDirections, bool animated)
		{
		}

		public void SetContentViewController(UIViewController viewController, bool animated)
		{
		}

		public void SetPopoverContentSize(CGSize size, bool animated)
		{
		}

		public void Dismiss(bool animated)
		{
		}
	}
}
