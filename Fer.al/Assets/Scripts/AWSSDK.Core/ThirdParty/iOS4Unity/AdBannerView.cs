using System;
using System.Collections.Generic;

namespace ThirdParty.iOS4Unity
{
	public class AdBannerView : UIView
	{
		private static readonly IntPtr _classHandle;

		private Dictionary<object, IntPtrHandler2> _failedToReceiveAd;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public AdType AdType
		{
			get
			{
				return default(AdType);
			}
		}

		public bool BannerLoaded
		{
			get
			{
				return default(bool);
			}
		}

		public event EventHandler AdLoaded
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler ActionFinished
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<NSErrorEventArgs> FailedToReceiveAd
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler WillLoad
		{
			add
			{
			}
			remove
			{
			}
		}

		static AdBannerView()
		{
		}

		public AdBannerView()
		{
		}

		public AdBannerView(CGRect frame)
		{
		}

		public AdBannerView(AdType type)
		{
		}

		internal AdBannerView(IntPtr handle)
		{
		}

		public void CancelBannerViewAction()
		{
		}
	}
}
