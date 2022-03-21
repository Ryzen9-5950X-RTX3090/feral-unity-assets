using UnityEngine;

public class SanctuaryPositionMessage : Message
{
	public readonly Vector3 mousePosition;

	public readonly Vector3 mouseDelta;

	public SanctuaryPositionMessage(Vector3 inMousePosition, Vector3 inMouseDelta)
	{
	}
}
