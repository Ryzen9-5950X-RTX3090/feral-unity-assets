using System.Collections.Generic;

public class AltResponseQueue
{
	private Queue<SendResponse> _responseQueue;

	private readonly object _queueLock;

	public void Cycle()
	{
	}

	public void ScheduleResponse(SendResponse newResponse)
	{
	}
}
