using Server;
using UnityEngine;

public struct WorldObjectMoveNodeData
{
	public WorldObjectMoverNodeType nodeType;

	public long serverTime;

	public Vector3 position;

	public Vector3 direction;

	public Quaternion rotation;

	public float speed;

	public ActorActionType actionType;

	public static WorldObjectMoveNodeData Read(INetMessageReader data)
	{
		return default(WorldObjectMoveNodeData);
	}
}
