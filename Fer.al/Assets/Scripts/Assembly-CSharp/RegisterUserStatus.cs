public static class RegisterUserStatus
{
	public const string SUCCESS = "";

	public const string ERROR_DISPLAY_NAME_NOT_PRESENT = "display_name_not_present";

	public const string ERROR_DISPLAY_NAME_INVALID_FORMAT = "display_name_invalid_format";

	public const string ERROR_DISPLAY_NAME_TOO_SHORT = "display_name_too_short";

	public const string ERROR_DISPLAY_NAME_TOO_LONG = "display_name_too_long";

	public const string ERROR_DISPLAY_NAME_PROFANITYCHECKFAILED = "display_name_profanity_check_failed";

	public const string ERROR_DISPLAY_NAME_SIFT_REJECTED = "display_name_sift_rejected";

	public const string ERROR_DISPLAY_NAME_CONTAINS_PASSWORD = "display_name_cannot_contain_password";

	public const string ERROR_DISPLAY_NAME_SAME_AS_OLD = "same_as_old_display_name";

	public const string ERROR_USERNAME_NOT_PRESENT = "username_not_present";

	public const string ERROR_PASSWORD_NOT_PRESENT = "password_not_present";

	public const string ERROR_PASSWORD_IS_TOO_SHORT = "password_is_too_short";

	public const string ERROR_PASSWORD_IS_TOO_LONG = "password_is_too_long";

	public const string ERROR_BIRTHDAY_NOT_PRESENT = "birthday_not_present";

	public const string ERROR_FUTURE_DATE_NOT_ALLOWED = "future_date_not_allowed";

	public const string ERROR_INVALID_DATE_FORMAT = "invalid_date_format";

	public const string ERROR_AGE_CRITERIA_FAILED = "age_criteria_failed";

	public const string ERROR_INVALID_GENDER = "invalid_gender";

	public const string ERROR_USERNAME_ALREADY_EXISTS = "username_already_exists";

	public const string ERROR_USERNAME_INVALID_FORMAT = "invalid_username";

	public const string ERROR_USERNAME_VALIDATION_FAILED = "username_validation_failed";

	public const string ERROR_REGISTRATION_NOT_ALLOWED = "registration_not_allowed";

	public const string ERROR_INTERAL_ERROR = "internal_error";

	public const string ERROR_EMAIL_INVALID = "invalid_email";

	public const string ERROR_PENDING_EMAIL_VALIDATION = "pending_otp_confirmation";

	public const string ERROR_INVALID_OTP = "invalid_otp";

	public const string ERROR_PASSWORD_IN_BLACKLIST = "password_in_blacklist";

	public const string ERROR_DATE_OUT_OF_RANGE = "date_out_of_range";

	public const string Error_Unknown = "unknown";

	public const string ERROR_DISPLAY_NAME_ALREADYTAKEN = "display_name_already_taken";

	public const string ERROR_DISPLAY_NAME_NEW_ALREADYTAKEN = "new_displayname_already_exists";
}
