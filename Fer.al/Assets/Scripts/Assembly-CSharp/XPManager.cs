using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using WW.Waiters;

public class XPManager : SingletonManagerBase<XPManager>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <GetPlayerLevel>d__6 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<IPlayerLevel> <>t__builder;

		public string inUUID;

		public XPManager <>4__this;

		private bool <isMe>5__2;

		private TaskAwaiter<WWWResponse<XPSrvHandler.RequestXPDetailsResponse>> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public IPlayerLevel PlayerLevel;

	private bool _isAggregatingXPMessages;

	private XPUpdateMessage _aggregatedXPMessage;

	private WW.Waiters.Waiter _aggregationWaiter;

	public override void Init()
	{
	}

	public override void Deinit()
	{
	}

	[AsyncStateMachine(typeof(<GetPlayerLevel>d__6))]
	public Task<IPlayerLevel> GetPlayerLevel(string inUUID)
	{
		return null;
	}

	private void OnLoginComplete(LoginCompleteResponse inMessage)
	{
	}

	private void OnXPUpdatedFromServer(XPUpdateServerMessage inMessage)
	{
	}

	private void OnHideHUDCommand(HideHUDCommand inMessage)
	{
	}
}
