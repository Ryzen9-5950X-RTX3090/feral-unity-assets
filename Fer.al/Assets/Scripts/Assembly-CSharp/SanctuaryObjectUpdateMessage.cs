using UnityEngine;

public class SanctuaryObjectUpdateMessage : Message
{
	public readonly SanctuaryObjectBase sanctuaryObject;

	public readonly SanctuarySurface surface;

	public readonly Vector3? hitPoint;

	public readonly Vector3? hitNormal;

	public readonly bool move;

	public readonly bool rotate;

	public readonly float? rotation;

	public readonly bool activeObject;

	public readonly bool updateToLastGood;

	public SanctuaryObjectUpdateMessage(SanctuaryObjectBase inSanctuaryObject, float? inRotation, RaycastHit? inHit, SanctuarySurface inSurface, bool inMove, bool inRotate, bool inActive, bool inUpdateToLastGood)
	{
	}
}
