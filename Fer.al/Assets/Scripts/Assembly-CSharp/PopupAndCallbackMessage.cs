using System;

public class PopupAndCallbackMessage : Message
{
	public string message;

	public string title;

	public Action<string> callback;

	public PopupAndCallbackMessage(string inMessage, string inTitle, Action<string> inCallback)
	{
	}
}
