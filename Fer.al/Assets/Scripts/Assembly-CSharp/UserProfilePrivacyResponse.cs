using System;

[Serializable]
public struct UserProfilePrivacyResponse
{
	public string voice_chat;

	public static PrivacySetting.PrivacyLevel GetPrivacySetting(string inSetting)
	{
		return default(PrivacySetting.PrivacyLevel);
	}
}
