using System;

namespace ThirdParty.iOS4Unity
{
	public class SKPaymentTransaction : NSObject
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public NSError Error
		{
			get
			{
				return null;
			}
		}

		public SKPaymentTransaction OriginalTransaction
		{
			get
			{
				return null;
			}
		}

		public DateTime TransactionDate
		{
			get
			{
				return default(DateTime);
			}
		}

		public string TransactionIdentifier
		{
			get
			{
				return null;
			}
		}

		static SKPaymentTransaction()
		{
		}

		internal SKPaymentTransaction(IntPtr handle)
		{
		}
	}
}
