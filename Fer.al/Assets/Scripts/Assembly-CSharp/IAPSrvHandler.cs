using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine.Purchasing;

public class IAPSrvHandler
{
	[Serializable]
	public class ProcessPurchaseRequest
	{
		public string transaction_id;

		public string uuid;

		public string currency_code;

		public decimal price;

		public string ip_address;

		public string store;

		public string product_id;

		public string payload;

		public ProcessPurchaseRequest()
		{
		}

		public ProcessPurchaseRequest(Product inProduct)
		{
		}
	}

	[Serializable]
	public class ProcessPurchaseResponse
	{
		public string error;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <ProcessPurchase>d__4 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<ProcessPurchaseResponse>> <>t__builder;

		public Product inProduct;

		private TaskAwaiter<WWWResponse<ProcessPurchaseResponse>> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public static string Host
	{
		get
		{
			return null;
		}
	}

	public static string Store
	{
		get
		{
			return null;
		}
	}

	[AsyncStateMachine(typeof(<ProcessPurchase>d__4))]
	public static Task<WWWResponse<ProcessPurchaseResponse>> ProcessPurchase(Product inProduct)
	{
		return null;
	}
}
