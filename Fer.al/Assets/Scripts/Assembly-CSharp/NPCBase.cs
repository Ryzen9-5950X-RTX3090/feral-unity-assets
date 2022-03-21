using System;
using UnityEngine;

public class NPCBase : ActorBase
{
	private BaseDef _npcDef;

	private string _cachedActorName;

	public BaseDef NPCDef
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public override string ActorName
	{
		get
		{
			return null;
		}
	}

	public static NPCBase CreateNPC(string inWorldObjectDefID, BaseDef inNPCDef, ActorInfo inInfo, Vector3 inPosition, Quaternion inRotation, Action<GameObject, ActorInfo> inFinishedCallback, bool inUseBubble = true)
	{
		return null;
	}

	public override void OnDisable()
	{
	}
}
