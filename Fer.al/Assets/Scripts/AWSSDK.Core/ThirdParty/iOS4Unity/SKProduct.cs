using System;

namespace ThirdParty.iOS4Unity
{
	public class SKProduct : NSObject
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public bool Downloadable
		{
			get
			{
				return default(bool);
			}
		}

		public string LocalizedDescription
		{
			get
			{
				return null;
			}
		}

		public string LocalizedTitle
		{
			get
			{
				return null;
			}
		}

		public double Price
		{
			get
			{
				return default(double);
			}
		}

		public NSLocale PriceLocale
		{
			get
			{
				return null;
			}
		}

		public string ProductIdentifier
		{
			get
			{
				return null;
			}
		}

		public SKPaymentTransactionState TransactionState
		{
			get
			{
				return default(SKPaymentTransactionState);
			}
		}

		static SKProduct()
		{
		}

		internal SKProduct(IntPtr handle)
		{
		}
	}
}
