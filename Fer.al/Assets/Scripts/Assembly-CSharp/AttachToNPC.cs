using UnityEngine;

public class AttachToNPC : ManagedBehaviour
{
	public Transform parentTransform;

	public string attachName;

	public Vector3 positionOffset;

	public Vector3 rotationOffset;

	private Transform foundTransform;

	public void Attach()
	{
	}

	private void FindAttachTransform()
	{
	}
}
