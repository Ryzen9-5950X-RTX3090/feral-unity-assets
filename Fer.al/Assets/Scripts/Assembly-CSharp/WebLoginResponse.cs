public struct WebLoginResponse
{
	public LoginStatus status;

	public string uuid;

	public string authToken;

	public string refreshToken;

	public string error;

	public bool renameRequired;

	public string renameRequiredKey;

	public bool IsSuccess
	{
		get
		{
			return default(bool);
		}
	}

	public static WebLoginResponse Fake
	{
		get
		{
			return default(WebLoginResponse);
		}
	}

	public void SetStatus(string inError)
	{
	}
}
