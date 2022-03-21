using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Server;

[MessageRouteHandler]
public static class LoginXtHandler
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestCompleteTutorial>d__0 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<TutorialCompleteResponse> <>t__builder;

		public string lookName;

		public AvatarLookItemComponent.Gender gender;

		public ActorInfo lookAppearanceInfo;

		private TaskAwaiter<TutorialCompleteResponse> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[AsyncStateMachine(typeof(<RequestCompleteTutorial>d__0))]
	[MessageSender(XtCmd.TutorialComplete, false)]
	public static Task<TutorialCompleteResponse> RequestCompleteTutorial(string lookName, AvatarLookItemComponent.Gender gender, ActorInfo lookAppearanceInfo)
	{
		return null;
	}

	[MessageSender(XtCmd.TutorialComplete_DEBUG, false)]
	public static void RequestCompleteTutorial_DEBUG()
	{
	}

	[MessageRoute(XtCmd.TutorialComplete, QueueMessageMode.Never)]
	public static void HandleTutorialCompleteResponse(TutorialCompleteResponse response)
	{
	}
}
