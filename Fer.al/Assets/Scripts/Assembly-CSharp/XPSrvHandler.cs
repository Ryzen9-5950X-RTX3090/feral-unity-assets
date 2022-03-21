using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public class XPSrvHandler
{
	[Serializable]
	public class RequestXPDetailsResponse
	{
		public XPDetailItem[] found;

		public XPDetailItem[] not_found;
	}

	[Serializable]
	public class XPDetailItem
	{
		public int total_xp;

		public string uuid;

		public XPLevelDetailItem current_level;
	}

	[Serializable]
	public class XPLevelDetailItem
	{
		public int level;

		public int xp;

		public int required;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestXPDetails>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<RequestXPDetailsResponse>> <>t__builder;

		public string inUUID;

		private TaskAwaiter<WWWResponse<RequestXPDetailsResponse>> <>u__1;

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

	[AsyncStateMachine(typeof(<RequestXPDetails>d__2))]
	public static Task<WWWResponse<RequestXPDetailsResponse>> RequestXPDetails(string inUUID)
	{
		return null;
	}
}
