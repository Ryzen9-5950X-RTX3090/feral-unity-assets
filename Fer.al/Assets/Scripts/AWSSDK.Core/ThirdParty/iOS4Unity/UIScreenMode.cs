using System;

namespace ThirdParty.iOS4Unity
{
	public class UIScreenMode : NSObject
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public float PixelAspectRatio
		{
			get
			{
				return default(float);
			}
		}

		public CGSize Size
		{
			get
			{
				return default(CGSize);
			}
		}

		static UIScreenMode()
		{
		}

		internal UIScreenMode(IntPtr handle)
		{
		}
	}
}
