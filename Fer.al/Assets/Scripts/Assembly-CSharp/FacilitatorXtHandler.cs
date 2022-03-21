using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using Server;

[MessageRouteHandler]
public static class FacilitatorXtHandler
{
	public enum DisciplineAction
	{
		Kick,
		Suspension,
		Ban,
		Warning
	}

	public enum ReportType
	{
		Player = 4,
		Masterpiece = 8
	}

	public enum DisciplineReason
	{
		None,
		Unknown1,
		Unknown2,
		Mean,
		Language,
		Personal,
		Security,
		Den,
		InappropriateBehavior,
		Scamming,
		TOSViolation,
		OtherBehavior,
		Unauthorized
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RequestReportUser>d__3 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<FacilitatorReportUserMessage> <>t__builder;

		public string reportedUserId;

		public UI_Window_ReportPlayer.ReportCategory reportCategory;

		public string reasonText;

		private TaskAwaiter<FacilitatorReportUserMessage> <>u__1;

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
	private struct <RequestNotificationUpdate>d__4 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<FacilitatorSetBusyMessage> <>t__builder;

		public NotificationStatus notificationStatus;

		private TaskAwaiter<FacilitatorSetBusyMessage> <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[AsyncStateMachine(typeof(<RequestReportUser>d__3))]
	[MessageSender(XtCmd.FacilitatorReport, false)]
	public static Task<FacilitatorReportUserMessage> RequestReportUser(string reportedUserId, UI_Window_ReportPlayer.ReportCategory reportCategory, string reasonText)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<RequestNotificationUpdate>d__4))]
	[MessageSender(XtCmd.FacilitatorSetBusy, false)]
	public static Task<FacilitatorSetBusyMessage> RequestNotificationUpdate(NotificationStatus notificationStatus)
	{
		return null;
	}

	[MessageRoute(XtCmd.FacilitatorDiscipline, QueueMessageMode.Never)]
	public static void HandleDiscipline(FacilitatorDisciplineResponse res)
	{
	}

	private static void Kick(bool inPermanent)
	{
	}
}
