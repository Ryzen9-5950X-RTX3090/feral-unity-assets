using System.Collections.Generic;

[ChartComponent("Chat Emoji")]
public class ChatEmojiDefComponent : DefComponent
{
	[ChartList]
	public List<string> localizedChatCommandDefIds;

	private List<string> _chatCommands;

	[ChartString]
	public string unicode;

	public List<string> ChatCommands
	{
		get
		{
			return null;
		}
	}

	public string GetDisplayString()
	{
		return null;
	}
}
