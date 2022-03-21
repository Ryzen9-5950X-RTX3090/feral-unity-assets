using UnityEngine;

[ManagedBehaviourManager("SanctuaryManager")]
public class SanctuarySurface : ManagedBehaviour
{
	private int _index;

	private bool _meshColliderChecked;

	private MeshCollider _meshCollider;

	private bool _boxColliderChecked;

	private BoxCollider _boxCollider;

	public MeshCollider meshCollider
	{
		get
		{
			return null;
		}
	}

	public BoxCollider boxCollider
	{
		get
		{
			return null;
		}
	}

	public override void MStart()
	{
	}

	public int GetIndex()
	{
		return default(int);
	}

	public void SetIndex(int inIndex)
	{
	}
}
