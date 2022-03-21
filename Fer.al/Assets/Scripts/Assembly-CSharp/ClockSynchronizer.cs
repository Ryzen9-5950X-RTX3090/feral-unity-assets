using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Server;

[MessageRouteHandler]
public class ClockSynchronizer : MonoBehaviour
{
	private class ClockSyncIntervalResponse : ServerMessage
	{
		public readonly long ServerTime;

		public ClockSyncIntervalResponse(INetMessageReader data)
		{
		}
	}

	private struct ClockSyncInterval
	{
		public readonly long myStartTime;

		public readonly long serverMidTime;

		public readonly long myRecvTime;

		public ClockSyncInterval(long myStartTime, long serverTime, long myRecvTime)
		{
		}
	}

	private const int NumClockSyncIntervalTrips = 10;

	private const long MaxClockSyncIntervalTripMs = 2000L;

	public Action<long> onCompleteEvent;

	private long _lastClockSyncSendTime;

	private int _numClockSyncTrips;

	private List<ClockSyncInterval> _clockSyncData;

	private static long _syncedServerTimeOffset;

	public static ClockSynchronizer instance
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public static void Begin(Action<long> onCompletedCallback)
	{
	}

	private void OnEnable()
	{
	}

	private void SynchronizeClock()
	{
	}

	private void OnInterval(ClockSyncIntervalResponse response)
	{
	}

	[MessageRoute(XtCmd.SyncClock, QueueMessageMode.Never)]
	private static void HandleClockSyncInterval(ClockSyncIntervalResponse response)
	{
	}

	[MessageSender(XtCmd.SyncClock, true)]
	private static void RequestClockSyncInterval()
	{
	}

	private void CalculateClockSyncOffset()
	{
	}
}
