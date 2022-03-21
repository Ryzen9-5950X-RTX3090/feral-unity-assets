using System.ComponentModel;

namespace VivoxUnity
{
	[DefaultValue(null)]
	public enum LoginState
	{
		LoggedOut,
		LoggedIn,
		LoggingIn,
		LoggingOut
	}
}
