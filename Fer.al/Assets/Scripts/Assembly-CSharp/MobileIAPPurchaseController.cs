using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using UnityEngine.Purchasing;

public class MobileIAPPurchaseController : IIAPPurchaseController, IStoreListener
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <WaitThenCheckPurchaseFailed>d__9 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public MobileIAPPurchaseController <>4__this;

		public Product i;

		public PurchaseFailureReason p;

		private UniTask.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <DoProcessPurchase>d__11 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public MobileIAPPurchaseController <>4__this;

		public Product inProduct;

		private int <attempts>5__2;

		private bool <retry>5__3;

		private WWWResponse<IAPSrvHandler.ProcessPurchaseResponse> <response>5__4;

		private TaskAwaiter<WWWResponse<IAPSrvHandler.ProcessPurchaseResponse>> <>u__1;

		private UniTask.Awaiter <>u__2;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private IStoreController controller;

	private string _developerPayload;

	private HashSet<string> _inProcessPurchases;

	private HashSet<string> _successfulPurchases;

	public void Setup(IAPItem[] inItems)
	{
	}

	public void OnInitialized(IStoreController controller, IExtensionProvider extensions)
	{
	}

	public void OnInitializeFailed(InitializationFailureReason error)
	{
	}

	public PurchaseProcessingResult ProcessPurchase(PurchaseEventArgs e)
	{
		return default(PurchaseProcessingResult);
	}

	public void OnPurchaseFailed(Product i, PurchaseFailureReason p)
	{
	}

	[AsyncStateMachine(typeof(<WaitThenCheckPurchaseFailed>d__9))]
	private void WaitThenCheckPurchaseFailed(Product i, PurchaseFailureReason p)
	{
	}

	public void PurchaseItem(IAPItem inItem)
	{
	}

	[AsyncStateMachine(typeof(<DoProcessPurchase>d__11))]
	private void DoProcessPurchase(Product inProduct)
	{
	}

	private void SendPurchaseEvent(Product inProduct)
	{
	}
}
