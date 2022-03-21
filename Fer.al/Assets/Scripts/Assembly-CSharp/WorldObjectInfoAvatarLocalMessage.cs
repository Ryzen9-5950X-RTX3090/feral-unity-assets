using Server;
using UnityEngine;

[RoutedMessage(XtCmd.WorldObjectInfoAvatarLocal, QueueMessageMode.Never)]
public class WorldObjectInfoAvatarLocalMessage : ServerMessage
{
	public readonly Vector3 SpawnPosition;

	public readonly Quaternion SpawnRotation;

	public WorldObjectInfoAvatarLocalMessage(INetMessageReader data)
	{
	}
}
