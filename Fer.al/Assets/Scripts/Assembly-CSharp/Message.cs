using System.Runtime.CompilerServices;

public class Message : IMessage
{
	public string EventId
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		set
		{
		}
	}

	protected Message()
	{
	}

	public Message(string inEventId)
	{
	}

	public virtual void ReturnToPool()
	{
	}
}
