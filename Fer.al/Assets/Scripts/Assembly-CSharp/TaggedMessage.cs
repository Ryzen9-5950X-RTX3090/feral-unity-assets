public class TaggedMessage : Message, ITaggedMessage
{
	protected string _tag;

	protected TaggedMessage()
	{
	}

	public TaggedMessage(string inTag)
	{
	}

	public TaggedMessage(string inEventId, string inTag)
	{
	}

	public string GetTag()
	{
		return null;
	}
}
