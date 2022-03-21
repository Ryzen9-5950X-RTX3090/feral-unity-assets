using System;

namespace ThirdParty.iOS4Unity
{
	public class UIView : NSObject
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public CGRect Frame
		{
			get
			{
				return default(CGRect);
			}
			set
			{
			}
		}

		public CGRect Bounds
		{
			get
			{
				return default(CGRect);
			}
			set
			{
			}
		}

		public CGPoint Center
		{
			get
			{
				return default(CGPoint);
			}
			set
			{
			}
		}

		public UIView[] Subviews
		{
			get
			{
				return null;
			}
		}

		public UIView Superview
		{
			get
			{
				return null;
			}
		}

		public bool Hidden
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public float Alpha
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public UIWindow Window
		{
			get
			{
				return null;
			}
		}

		static UIView()
		{
		}

		public UIView()
		{
		}

		public UIView(CGRect frame)
		{
		}

		internal UIView(IntPtr handle)
		{
		}

		public void AddSubview(UIView view)
		{
		}

		public void BringSubviewToFront(UIView view)
		{
		}

		public void SendSubviewToBack(UIView view)
		{
		}

		public void RemoveFromSuperview()
		{
		}
	}
}
