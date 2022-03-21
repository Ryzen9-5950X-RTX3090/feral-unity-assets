using System;
using System.Runtime.CompilerServices;
using System.Threading;

public class MessagePump
{
	public delegate bool DoneDelegate();

	private static MessagePump _instance;

	public static MessagePump Instance
	{
		get
		{
			return null;
		}
	}

	public event RunLoop MainLoopRun
	{
		[CompilerGenerated]
		add
		{
		}
		[CompilerGenerated]
		remove
		{
		}
	}

	private MessagePump()
	{
	}

	public void RunUntil(LoopDone done)
	{
	}

	public void RunOnce()
	{
	}

	public static bool IsDone(WaitHandle handle, DateTime until)
	{
		return default(bool);
	}

	public static bool Run(WaitHandle handle, TimeSpan until)
	{
		return default(bool);
	}
}
