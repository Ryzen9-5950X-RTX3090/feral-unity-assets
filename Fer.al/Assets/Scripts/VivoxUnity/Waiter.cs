using System;
using System.Threading;

public class Waiter
{
	private WaitHandle _waitHandle;

	private DateTime _until;

	public Waiter(WaitHandle handle, TimeSpan until)
	{
	}

	public bool IsDone()
	{
		return default(bool);
	}
}
