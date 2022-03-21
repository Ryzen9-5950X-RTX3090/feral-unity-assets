using System;

namespace ThirdParty.iOS4Unity
{
	public class UIViewController : NSObject
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
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

		public UIView View
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public bool IsViewLoaded
		{
			get
			{
				return default(bool);
			}
		}

		public UIViewController ParentViewController
		{
			get
			{
				return null;
			}
		}

		public UIViewController PresentedViewController
		{
			get
			{
				return null;
			}
		}

		public UIViewController PresentingViewController
		{
			get
			{
				return null;
			}
		}

		static UIViewController()
		{
		}

		public UIViewController()
		{
		}

		internal UIViewController(IntPtr handle)
		{
		}

		public void LoadView()
		{
		}

		public void PresentViewController(UIViewController controller, bool animated = true)
		{
		}

		public void DismissViewController(bool animated = true)
		{
		}
	}
}
