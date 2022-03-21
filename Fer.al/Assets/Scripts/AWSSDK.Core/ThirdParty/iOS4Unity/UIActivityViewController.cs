using System;

namespace ThirdParty.iOS4Unity
{
	public class UIActivityViewController : UIViewController
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		static UIActivityViewController()
		{
		}

		public UIActivityViewController(string text)
		{
		}

		public UIActivityViewController(UIImage image)
		{
		}

		public UIActivityViewController(string text, UIImage image)
		{
		}

		internal UIActivityViewController(IntPtr handle)
		{
		}
	}
}
