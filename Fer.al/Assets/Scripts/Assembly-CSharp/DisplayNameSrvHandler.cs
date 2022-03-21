using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Server;

[MessageRouteHandler]
public static class DisplayNameSrvHandler
{
	[Serializable]
	public struct RenameDisplayNameRequestBody
	{
		public string new_display_name;

		public string cached_action_key;
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <Validate>d__2 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<ValidateDisplayNameResponse>> <>t__builder;

		public string username;

		public string clientAuth;

		private TaskAwaiter<WWWResponse<ValidateDisplayNameResponse>> <>u__1;

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
	private struct <Rename>d__3 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<RenameDisplayNameResponse>> <>t__builder;

		public string inNewDisplayName;

		public string inRenameRequiredKey;

		private TaskAwaiter<WWWResponse<RenameDisplayNameResponse>> <>u__1;

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

	[AsyncStateMachine(typeof(<Validate>d__2))]
	public static Task<WWWResponse<ValidateDisplayNameResponse>> Validate(string username, string clientAuth)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<Rename>d__3))]
	public static Task<WWWResponse<RenameDisplayNameResponse>> Rename(string inNewDisplayName, string inRenameRequiredKey)
	{
		return null;
	}
}
