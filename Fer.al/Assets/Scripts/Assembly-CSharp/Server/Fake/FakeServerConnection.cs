using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace Server.Fake
{
	public class FakeServerConnection : ServerConnection
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <DisconnectAsync>d__4 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncTaskMethodBuilder <>t__builder;

			private TaskAwaiter <>u__1;

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
		private struct <Login>d__5 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncTaskMethodBuilder<ServerLoginResponse> <>t__builder;

			public string loginUUID;

			public FakeServerConnection <>4__this;

			private ServerLoginResponse <loginMessage>5__2;

			private TaskAwaiter <>u__1;

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
		private struct <Logout>d__6 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncVoidMethodBuilder <>t__builder;

			public FakeServerConnection <>4__this;

			private TaskAwaiter <>u__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private FakeServer _fakeServer;

		public FakeServerConnection(FeralServerEnvironment env)
		{
		}

		public override void Init(FeralServerEnvironment env)
		{
		}

		public override Task<bool> Connect(string host)
		{
			return null;
		}

		[AsyncStateMachine(typeof(<DisconnectAsync>d__4))]
		public override Task DisconnectAsync()
		{
			return null;
		}

		[AsyncStateMachine(typeof(<Login>d__5))]
		public override Task<ServerLoginResponse> Login(string loginUUID, string authToken, int sessionId)
		{
			return null;
		}

		[AsyncStateMachine(typeof(<Logout>d__6))]
		public override void Logout()
		{
		}

		public override void Switching()
		{
		}

		public override void Send(INetMessageWriter message)
		{
		}

		public override void ProcessEventQueue()
		{
		}
	}
}
