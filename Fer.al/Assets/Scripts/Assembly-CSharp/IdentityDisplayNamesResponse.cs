using System;

[Serializable]
public class IdentityDisplayNamesResponse
{
	[Serializable]
	public struct Identity
	{
		public string uuid;

		public string display_name;
	}

	public Identity[] found;

	public string[] not_found;

	public IdentityDisplayNamesResponse()
	{
	}

	public IdentityDisplayNamesResponse(string uuid, string fakeName)
	{
	}
}
