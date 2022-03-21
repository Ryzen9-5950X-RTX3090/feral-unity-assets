using System.Runtime.CompilerServices;
using Server;

public class ParlorGameMessage : ServerMessage
{
	public XtReader XtReaderData;

	public string ParlorGameCmd
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

	public ParlorGameMessage(XtReader data)
	{
	}
}
