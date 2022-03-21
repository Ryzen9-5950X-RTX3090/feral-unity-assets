using System.Collections.Generic;

public class ChatThrottler
{
	private int _chatSampleSize;

	private float _maxChatsPerSecond;

	private List<float> _chatTimes;

	public ChatThrottler(int chatSampleSize, float maxChatsPerSecond)
	{
	}

	public bool RequestChatPermission()
	{
		return default(bool);
	}
}
