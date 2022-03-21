public class WindowClosedMessage : WindowMessage
{
	protected WindowClosedMessage(string inTag, UI_Window inWindow)
	{
	}

	public static WindowClosedMessage Create(string inTag, UI_Window inWindow)
	{
		return null;
	}

	public override void ReturnToPool()
	{
	}
}
