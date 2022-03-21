using UnityEngine;

public class InteractableHarvestedMessage : Message
{
	public readonly int Quantity;

	public readonly Vector3 WorldPosition;

	public readonly string DefId;

	public InteractableHarvestedMessage(int inQuantity, Vector3 inWorldPosition, string inDefId)
	{
	}
}
