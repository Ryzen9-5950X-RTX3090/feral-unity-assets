public enum LoginStatus
{
	Success = 1,
	Rename_Required = 2,
	Error_UnexpectedError = -1,
	Error_InvalidLogin = -10,
	Error_InUse = -11,
	Error_AccountMaintenance = -12,
	Error_Suspended = -15,
	Error_ServerMaintenance = -16,
	Error_LoginWithTokenFailed = -19,
	Error_BadUserData = -21,
	Error_RequestTimeout = -22,
	Error_FinishedWithNoConnection = -23,
	Error_ClientVersionMismatch = -24,
	Error_AccountDisabled = -26,
	Error_BadLanguageId = -28,
	Error_NotConnected = -1000
}
