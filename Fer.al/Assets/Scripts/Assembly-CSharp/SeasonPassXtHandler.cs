using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Server;

public class SeasonPassXtHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <PurchaseTierRequest>d__0 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<SeasonPassPurchaseTierResponse> <>t__builder;

		public int tierToPurchase;

		public int expectedAuraPointCost;

		public int expectedStarFragmentCost;

		public string tierDefId;

		public string seasonDefId;

		private TaskAwaiter<SeasonPassPurchaseTierResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[AsyncStateMachine(typeof(<PurchaseTierRequest>d__0))]
	[MessageSender(XtCmd.SeasonPassPurchaseTier, false)]
	public static Task<SeasonPassPurchaseTierResponse> PurchaseTierRequest(int tierToPurchase, int expectedStarFragmentCost, int expectedAuraPointCost, string tierDefId, string seasonDefId)
	{
		return null;
	}
}
