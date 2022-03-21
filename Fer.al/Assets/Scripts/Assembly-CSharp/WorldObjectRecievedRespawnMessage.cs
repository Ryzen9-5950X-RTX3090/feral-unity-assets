using Server;
using UnityEngine;

public class WorldObjectRecievedRespawnMessage : ServerMessage, ITaggedMessage
{
	public readonly string UserUUID;

	public readonly Vector3 position;

	public readonly Quaternion rotation;

	public readonly bool isMe;

	public string GetTag()
	{
		return null;
	}

	public WorldObjectRecievedRespawnMessage(INetMessageReader data)
	{
	}
}
