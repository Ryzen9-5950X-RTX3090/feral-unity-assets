using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UniRx.Async;
using WW.Debug;

public class SeasonPassManager : SingletonManagerBase<SeasonPassManager>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <LoadSeasonPass>d__4 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		public SeasonPassManager <>4__this;

		private SeasonPass <seasonPass>5__2;

		private WWWResponse<SeasonSrvHandler.RequestSeasonPassResponse> <spResponse>5__3;

		private WWWResponse<SeasonSrvHandler.ListChallengesResponse> <currentChallengesResponse>5__4;

		private TaskAwaiter<WWWResponse<SeasonSrvHandler.RequestSeasonPassResponse>> <>u__1;

		private TaskAwaiter<WWWResponse<SeasonSrvHandler.ListChallengesResponse>> <>u__2;

		private UniTask.Awaiter <>u__3;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public ISeasonPass SeasonPass;

	public ContentVisitRecord SeasonPassWindowVisitRecord;

	public override void Init()
	{
	}

	public override void Deinit()
	{
	}

	public override void MUpdate()
	{
	}

	[AsyncStateMachine(typeof(<LoadSeasonPass>d__4))]
	private void LoadSeasonPass()
	{
	}

	private void OnLoginComplete(LoginCompleteResponse inMessage)
	{
	}

	[DebugButton("Expire", "Season Pass", false, true)]
	private void DoSeasonPassExpiration()
	{
	}

	public bool HasSeasonPassBeenVisitedSinceNewPass()
	{
		return default(bool);
	}
}
