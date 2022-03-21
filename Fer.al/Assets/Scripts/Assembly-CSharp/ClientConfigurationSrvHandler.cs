using System;
using System.Collections;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Server;

[MessageRouteHandler]
public static class ClientConfigurationSrvHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestClientConfigurationByVersionAsync>d__1 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<WWWResponse<ClientConfigurationRequestConfigurationResponse>> <>t__builder;

		private TaskAwaiter<WWWResponse<ClientConfigurationRequestConfigurationResponse>> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public static string Host;

	[AsyncStateMachine(typeof(<RequestClientConfigurationByVersionAsync>d__1))]
	public static Task<WWWResponse<ClientConfigurationRequestConfigurationResponse>> RequestClientConfigurationByVersionAsync()
	{
		return null;
	}

	[IteratorStateMachine(typeof(<RequestClientConfigurationByVersion>d__2))]
	public static IEnumerator RequestClientConfigurationByVersion(Action<WWWResponse<ClientConfigurationRequestConfigurationResponse>> responseCallback)
	{
		return null;
	}
}
