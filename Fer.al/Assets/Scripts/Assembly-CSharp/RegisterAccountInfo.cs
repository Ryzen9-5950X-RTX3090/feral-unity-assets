public class RegisterAccountInfo
{
	public enum Gender
	{
		Female,
		Male,
		None
	}

	public string uuid;

	public string display_name;

	public string email;

	public string password;

	public int birthdayMonth;

	public int birthdayDay;

	public int birthdayYear;

	public Gender gender;

	public bool marketingOptIn;

	public string emailVerificationCode;
}
