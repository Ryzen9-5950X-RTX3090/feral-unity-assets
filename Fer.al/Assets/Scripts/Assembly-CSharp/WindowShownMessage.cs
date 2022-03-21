public class WindowShownMessage : WindowMessage
{
	protected WindowShownMessage(string inTag, UI_Window inWindow)
	{
	}

	public static WindowShownMessage Create(string inTag, UI_Window inWindow)
	{
		return null;
	}

	public override void ReturnToPool()
	{
	}
}
