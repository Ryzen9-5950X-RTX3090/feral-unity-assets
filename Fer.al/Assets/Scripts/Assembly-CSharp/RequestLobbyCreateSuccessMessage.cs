using System.Runtime.CompilerServices;

public class RequestLobbyCreateSuccessMessage : Message
{
	public string assocDefId
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public RequestLobbyCreateSuccessMessage(LobbyManager.ELobbyType inLobbyType, string inAssocDefId)
	{
	}
}
