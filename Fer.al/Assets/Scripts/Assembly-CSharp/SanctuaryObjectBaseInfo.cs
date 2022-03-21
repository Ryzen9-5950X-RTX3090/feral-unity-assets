using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class SanctuaryObjectBaseInfo : WorldObjectInfo
{
	public int index;

	public Vector3 position;

	public Quaternion rotation;

	public SanctuaryType type;

	public Item item;

	public string parentItemId;

	public int stateId;

	public int expansionIndex;

	public List<int> enlargedAreas;

	public List<RoomData> roomData;

	public SanctuaryObjectBaseInfo(int inGridIndex, Vector3 inPosition, Quaternion inRotation, int inStateId)
	{
	}

	public SanctuaryObjectBaseInfo(WorldObjectInfoMessage inInfoMessage)
	{
	}
}
