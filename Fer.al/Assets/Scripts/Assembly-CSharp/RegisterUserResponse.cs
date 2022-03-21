public struct RegisterUserResponse
{
	public string refresh_token;

	public string auth_token;

	public string uuid;

	public string error;

	public bool IsSuccess
	{
		get
		{
			return default(bool);
		}
	}

	public static bool IsInvalidOTP(string inStatus)
	{
		return default(bool);
	}

	public static bool IsPendingEmailValidationError(string inStatus)
	{
		return default(bool);
	}

	public static bool IsEmailError(string inStatus)
	{
		return default(bool);
	}

	public static bool IsDisplaynameError(string inStatus)
	{
		return default(bool);
	}

	public static bool IsPasswordError(string inStatus)
	{
		return default(bool);
	}

	public static bool IsBirthdayError(string inStatus)
	{
		return default(bool);
	}

	public static string GetLocalizedError(string inStatus)
	{
		return null;
	}
}
