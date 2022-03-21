using UnityEngine;

public class UVScroll : ManagedBehaviour
{
	[SerializeField]
	private int materialIndex;

	[SerializeField]
	private Vector2 uvAnimationRate;

	[SerializeField]
	private string textureName;

	private Vector2 uvOffset;

	private Renderer _renderer;

	private Material _targetMaterial;

	public override void MStart()
	{
	}

	public override void MUpdate()
	{
	}

	public void reset()
	{
	}
}
