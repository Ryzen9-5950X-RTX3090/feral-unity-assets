using System;

namespace ThirdParty.iOS4Unity
{
	public sealed class SKProductsResponse : NSObject
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public string[] InvalidProducts
		{
			get
			{
				return null;
			}
		}

		public SKProduct[] Products
		{
			get
			{
				return null;
			}
		}

		static SKProductsResponse()
		{
		}

		internal SKProductsResponse(IntPtr handle)
		{
		}
	}
}
