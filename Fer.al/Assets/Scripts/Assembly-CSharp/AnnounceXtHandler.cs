using System.Collections;
using System.Runtime.CompilerServices;
using Server;

[MessageRouteHandler]
public static class AnnounceXtHandler
{
	private static float _sysAnnounceRandomTime;

	[MessageRoute(XtCmd.Announcement, QueueMessageMode.Never)]
	public static void HandleSystemAnnounce(SystemAnnouncementMessage inMsg)
	{
	}

	[MessageRoute(XtCmd.SystemPopup, QueueMessageMode.Never)]
	public static void HandleSystemPopup(SystemPopupMessage inMsg)
	{
	}

	[IteratorStateMachine(typeof(<RandomTimerForRelogPopup>d__3))]
	private static IEnumerator RandomTimerForRelogPopup(SystemAnnouncementMessage inMsg)
	{
		return null;
	}

	private static void DoRelogForForcedRelogin()
	{
	}

	private static void DoRelogForDrain()
	{
	}
}
