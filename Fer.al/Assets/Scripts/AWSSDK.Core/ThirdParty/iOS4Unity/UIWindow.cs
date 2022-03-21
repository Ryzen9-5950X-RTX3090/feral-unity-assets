using System;

namespace ThirdParty.iOS4Unity
{
	public sealed class UIWindow : UIView
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public bool IsKeyWindow
		{
			get
			{
				return default(bool);
			}
		}

		public UIScreen Screen
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public float WindowLevel
		{
			get
			{
				return default(float);
			}
			set
			{
			}
		}

		public UIViewController RootViewController
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		static UIWindow()
		{
		}

		public UIWindow()
		{
		}

		public UIWindow(CGRect frame)
		{
		}

		internal UIWindow(IntPtr handle)
		{
		}

		public void BecomeKeyWindow()
		{
		}

		public void MakeKeyAndVisible()
		{
		}

		public void MakeKeyWindow()
		{
		}

		public void ResignKeyWindow()
		{
		}
	}
}
