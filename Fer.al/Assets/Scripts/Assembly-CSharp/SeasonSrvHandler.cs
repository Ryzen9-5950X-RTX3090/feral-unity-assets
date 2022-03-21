using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public class SeasonSrvHandler
{
	[Serializable]
	public class RequestSeasonPassResponse
	{
		public string def_id;

		public string uuid;

		public int current_level;

		public int current_points;

		public bool has_pass;

		public bool completed;

		public string end_date;
	}

	[Serializable]
	public class ListChallengesResponse
	{
		[Serializable]
		public class ChallengeItem
		{
			public string def_id;

			public int progress_count;
		}

		public string error;

		public ChallengeItem[] challenges;

		public bool IsSuccess
		{
			get
			{
				return default(bool);
			}
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestSeasonPass>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<RequestSeasonPassResponse>> <>t__builder;

		private TaskAwaiter<WWWResponse<RequestSeasonPassResponse>> <>u__1;

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
	private struct <RequestChallenges>d__3 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<ListChallengesResponse>> <>t__builder;

		public string inSeasonUUID;

		private TaskAwaiter<WWWResponse<ListChallengesResponse>> <>u__1;

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
	private struct <RequestCompletedChallenges>d__4 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<ListChallengesResponse>> <>t__builder;

		public string inSeasonUUID;

		private TaskAwaiter<WWWResponse<ListChallengesResponse>> <>u__1;

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

	[AsyncStateMachine(typeof(<RequestSeasonPass>d__2))]
	public static Task<WWWResponse<RequestSeasonPassResponse>> RequestSeasonPass()
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestChallenges>d__3))]
	public static Task<WWWResponse<ListChallengesResponse>> RequestChallenges(string inSeasonUUID)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestCompletedChallenges>d__4))]
	public static Task<WWWResponse<ListChallengesResponse>> RequestCompletedChallenges(string inSeasonUUID)
	{
		return null;
	}
}
