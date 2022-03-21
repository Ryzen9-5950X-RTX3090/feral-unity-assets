using System.Collections.Generic;
using UnityEngine;

[ManagedBehaviourManager("SanctuaryManager")]
public class SanctuaryInterior : ManagedBehaviour
{
	[Header("Entry")]
	public SanctuaryIndoorRoom entryRoom;

	[Header("Infos")]
	public List<SanctuaryIndoorRoom> indoorRooms;

	public void ClearRooms()
	{
	}
}
