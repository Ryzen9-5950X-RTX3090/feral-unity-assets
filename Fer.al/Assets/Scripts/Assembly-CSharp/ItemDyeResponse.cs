using System.Runtime.CompilerServices;
using Server;

[RoutedMessage(XtCmd.ItemUseDye, QueueMessageMode.Never)]
public class ItemDyeResponse : ServerMessage, ITaggedMessage, ISuccessMessage
{
	[CompilerGenerated]
	private readonly bool <Success>k__BackingField;

	[CompilerGenerated]
	private readonly string <ItemId>k__BackingField;

	public bool Success
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
	}

	public string ItemId
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
	}

	public string GetTag()
	{
		return null;
	}

	public ItemDyeResponse(INetMessageReader data)
	{
	}
}
