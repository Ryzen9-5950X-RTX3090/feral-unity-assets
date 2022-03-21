using UnityEngine;

public class WorldEvent : ManagedBehaviour
{
	[SerializeField]
	protected int _id;

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	protected virtual void OnWorldEvent(WorldEventMessage inWorldEventMessage)
	{
	}
}
