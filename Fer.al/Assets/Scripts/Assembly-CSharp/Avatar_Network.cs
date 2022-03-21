using System;
using UnityEngine;

public class Avatar_Network : AvatarBase
{
	public static Avatar_Network CreateNetwork(string inWorldObjectDefID, ActorInfo inInfo, Vector3 inPosition, Quaternion inRotation, Action<GameObject, ActorInfo> inFinishedCallback)
	{
		return null;
	}

	public override void OnObjectInfo(WorldObjectInfoMessage inInfoMessage)
	{
	}
}
