using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Server;
using UniRx.Async;
using UniRx.Async.CompilerServices;

namespace Services.VoiceChat
{
	[MessageRouteHandler]
	public static class VoiceChatSrvHandler
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <RequestNewCall>d__3 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<VoiceChatServiceRequests.VoiceChatCallGetResponse> <>t__builder;

			public string uuid;

			private TaskAwaiter<VoiceChatServiceRequests.VoiceChatCallGetResponse> <>u__1;

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
		private struct <RequestAddPlayer>d__4 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<VoiceChatServiceRequests.VoiceChatInvitePlayerGetResponse> <>t__builder;

			public string uuid;

			private TaskAwaiter<VoiceChatServiceRequests.VoiceChatInvitePlayerGetResponse> <>u__1;

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
		private struct <RequestLeaveCall>d__5 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<VoiceChatServiceRequests.VoiceChatLeaveCallGetResponse> <>t__builder;

			private TaskAwaiter<VoiceChatServiceRequests.VoiceChatLeaveCallGetResponse> <>u__1;

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
		private struct <RequestCallAttendees>d__6 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncUniTaskMethodBuilder<VoiceChatServiceRequests.VoiceChatGetAttendeesResponse> <>t__builder;

			private TaskAwaiter<VoiceChatServiceRequests.VoiceChatGetAttendeesResponse> <>u__1;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		private static VoiceChatServiceRequests.VoiceChatPingRequest _pingRequest;

		public static void RequestSessionStart()
		{
		}

		public static void Ping()
		{
		}

		[AsyncStateMachine(typeof(<RequestNewCall>d__3))]
		public static UniTask<VoiceChatServiceRequests.VoiceChatCallGetResponse> RequestNewCall(string uuid)
		{
			return default(UniTask<VoiceChatServiceRequests.VoiceChatCallGetResponse>);
		}

		[AsyncStateMachine(typeof(<RequestAddPlayer>d__4))]
		public static UniTask<VoiceChatServiceRequests.VoiceChatInvitePlayerGetResponse> RequestAddPlayer(string uuid)
		{
			return default(UniTask<VoiceChatServiceRequests.VoiceChatInvitePlayerGetResponse>);
		}

		[AsyncStateMachine(typeof(<RequestLeaveCall>d__5))]
		public static UniTask<VoiceChatServiceRequests.VoiceChatLeaveCallGetResponse> RequestLeaveCall()
		{
			return default(UniTask<VoiceChatServiceRequests.VoiceChatLeaveCallGetResponse>);
		}

		[AsyncStateMachine(typeof(<RequestCallAttendees>d__6))]
		public static UniTask<VoiceChatServiceRequests.VoiceChatGetAttendeesResponse> RequestCallAttendees()
		{
			return default(UniTask<VoiceChatServiceRequests.VoiceChatGetAttendeesResponse>);
		}
	}
}
