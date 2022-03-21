using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public static class IdentityService
{
	[Serializable]
	private class GetPlayerNamesParams
	{
		public List<string> uuids;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <GetDisplayName>d__3 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<string> <>t__builder;

		public string uuid;

		public string clientAuth;

		private TaskAwaiter <>u__1;

		private TaskAwaiter<WWWResponse<IdentityDisplayNamesResponse>> <>u__2;

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
	private struct <GetDisplayNames>d__4 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<IdentityDisplayNamesResponse>> <>t__builder;

		public List<string> uuids;

		public string clientAuth;

		private TaskAwaiter <>u__1;

		private TaskAwaiter<WWWResponse<IdentityDisplayNamesResponse>> <>u__2;

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

	[AsyncStateMachine(typeof(<GetDisplayName>d__3))]
	public static Task<string> GetDisplayName(string uuid, string clientAuth)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<GetDisplayNames>d__4))]
	public static Task<WWWResponse<IdentityDisplayNamesResponse>> GetDisplayNames(List<string> uuids, string clientAuth)
	{
		return null;
	}
}
