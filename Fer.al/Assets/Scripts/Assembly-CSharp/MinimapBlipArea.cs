using UnityEngine;

[ManagedBehaviourManager("MinimapManager")]
public class MinimapBlipArea : MinimapBlip
{
	public enum EColorType
	{
		Primary,
		Daily,
		UserControlled
	}

	public EColorType colorType;

	public GameObject mainBlip;

	public Color color;

	[SerializeField]
	private float _radius;

	private Color _color;

	private CapsuleCollider _capsuleCollider;

	public override void MAwake()
	{
	}

	public override void MUpdate()
	{
	}

	private void OnTriggerEnter(Collider inCollider)
	{
	}

	private void OnTriggerExit(Collider inCollider)
	{
	}

	private void OnDrawGizmosSelected()
	{
	}
}
