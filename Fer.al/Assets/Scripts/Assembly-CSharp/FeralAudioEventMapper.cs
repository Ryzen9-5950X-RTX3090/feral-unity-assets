using System;
using System.Collections.Generic;

public class FeralAudioEventMapper
{
	[Serializable]
	public class EventBankDictionaryEntry
	{
		public string key;

		public string value;
	}

	[Serializable]
	public class EventBankDictionary
	{
		public EventBankDictionaryEntry[] items;
	}

	private static FeralAudioEventMapper _instance;

	private Dictionary<string, string> _eventBankMap;

	public static FeralAudioEventMapper instance
	{
		get
		{
			return null;
		}
	}

	public Dictionary<string, string> eventBankMap
	{
		get
		{
			return null;
		}
	}

	private static void Log(object inObject)
	{
	}

	public string LookupBank(string eventId)
	{
		return null;
	}
}
