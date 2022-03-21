using System;
using System.Collections.Generic;
using LitJson;

[Serializable]
public class LoginData
{
	public string activeLookId;

	public int avatarInvId;

	public string sanctuaryLookId;

	public int pendingFlags;

	public Dictionary<string, int> inventoryMaxes;

	public int userId;

	public int sessionId;

	public long jamaaTime;

	public void Load(JsonData json)
	{
	}
}
