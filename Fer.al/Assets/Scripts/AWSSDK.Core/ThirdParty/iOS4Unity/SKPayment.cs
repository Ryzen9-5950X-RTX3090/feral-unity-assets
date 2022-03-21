using System;

namespace ThirdParty.iOS4Unity
{
	public class SKPayment : NSObject
	{
		private static readonly IntPtr _classHandle;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public string ApplicationUsername
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

		public int Quantity
		{
			get
			{
				return default(int);
			}
		}

		static SKPayment()
		{
		}

		internal SKPayment(IntPtr handle)
		{
		}

		public static SKPayment PaymentWithProduct(SKProduct product)
		{
			return null;
		}
	}
}
