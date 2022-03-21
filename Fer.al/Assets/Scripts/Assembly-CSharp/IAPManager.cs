using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;

public class IAPManager : SingletonManagerBase<IAPManager>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <GetIAPs>d__8 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public IAPManager <>4__this;

		private UniTask<ListIAPsResponse>.Awaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	private IAPItem[] _items;

	private IIAPPurchaseController _purchaseFlow;

	public IAPItem[] Items
	{
		get
		{
			return null;
		}
	}

	public override void Init()
	{
	}

	public override void Deinit()
	{
	}

	public void PurchaseItem(IAPItem inItem)
	{
	}

	private void OnLoginComplete(LoginCompleteMessage inMessage)
	{
	}

	[AsyncStateMachine(typeof(<GetIAPs>d__8))]
	private void GetIAPs()
	{
	}
}
