using System;

namespace VivoxUnity
{
	public interface IAccessTokenServer
	{
		string Issuer { get; }

		string Key { get; }

		TimeSpan ExpirationTimeSpan { get; }
	}
}
