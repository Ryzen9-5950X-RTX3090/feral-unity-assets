public class WindowOpenCompleteMessage : WindowMessage
{
	protected WindowOpenCompleteMessage(string inTag, UI_Window inWindow)
	{
	}

	public static WindowOpenCompleteMessage Create(string inTag, UI_Window inWindow)
	{
		return null;
	}

	public override void ReturnToPool()
	{
	}
}
