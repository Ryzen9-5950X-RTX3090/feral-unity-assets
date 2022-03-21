public struct PasswordResetResponse
{
	public string email;

	public string error;

	public bool IsSuccess
	{
		get
		{
			return default(bool);
		}
	}
}
