using System.Threading;

public class AltSocketClientThreadHolder
{
	protected readonly Thread thread;

	protected readonly AltClientSocketHandler handler;

	public Thread Thread
	{
		get
		{
			return null;
		}
	}

	public AltClientSocketHandler Handler
	{
		get
		{
			return null;
		}
	}

	public AltSocketClientThreadHolder(Thread thread, AltClientSocketHandler handler)
	{
	}
}
