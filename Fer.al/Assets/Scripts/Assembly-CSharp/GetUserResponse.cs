public struct GetUserResponse
{
	public string uuid;

	public string language;

	public string country_code;

	public string birthday;

	public string gender;

	public string username;

	public string display_name;

	public UserProfilePrivacyResponse privacy;

	public string enhanced_customization;

	public string error;

	public bool IsSuccess
	{
		get
		{
			return default(bool);
		}
	}
}
