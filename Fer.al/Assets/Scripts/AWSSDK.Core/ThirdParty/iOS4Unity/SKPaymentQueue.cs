using System;
using System.Collections.Generic;

namespace ThirdParty.iOS4Unity
{
	public class SKPaymentQueue : NSObject
	{
		private static readonly IntPtr _classHandle;

		private Dictionary<object, IntPtrHandler2> _restoreFailed;

		private Dictionary<object, IntPtrHandler2> _updatedTransactions;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public static bool CanMakePayments
		{
			get
			{
				return default(bool);
			}
		}

		public SKPaymentTransaction[] Transactions
		{
			get
			{
				return null;
			}
		}

		public static SKPaymentQueue DefaultQueue
		{
			get
			{
				return null;
			}
		}

		public event EventHandler RestoreCompleted
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<NSErrorEventArgs> RestoreFailed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<SKPaymentTransactionEventArgs> UpdatedTransactions
		{
			add
			{
			}
			remove
			{
			}
		}

		static SKPaymentQueue()
		{
		}

		internal SKPaymentQueue(IntPtr handle)
		{
		}

		public void AddPayment(SKPayment payment)
		{
		}

		public void RestoreCompletedTransactions()
		{
		}

		public void FinishTransaction(SKPaymentTransaction transaction)
		{
		}

		public override void Dispose()
		{
		}
	}
}
