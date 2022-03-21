using System;
using System.Collections.Generic;

namespace ThirdParty.iOS4Unity
{
	public class SKProductsRequest : NSObject
	{
		private static readonly IntPtr _classHandle;

		private Dictionary<object, IntPtrHandler2> _receivedResponse;

		private Dictionary<object, IntPtrHandler2> _failed;

		public override IntPtr ClassHandle
		{
			get
			{
				return default(IntPtr);
			}
		}

		public event EventHandler<SKProductsResponseEventArgs> ReceivedResponse
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler<NSErrorEventArgs> Failed
		{
			add
			{
			}
			remove
			{
			}
		}

		public event EventHandler Finished
		{
			add
			{
			}
			remove
			{
			}
		}

		static SKProductsRequest()
		{
		}

		public SKProductsRequest(string[] productIds)
		{
		}

		internal SKProductsRequest(IntPtr handle)
		{
		}

		public void Cancel()
		{
		}

		public void Start()
		{
		}
	}
}
