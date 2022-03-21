using UnityEngine;

public class ActiveOnDebugOnly : ManagedBehaviour
{
	[SerializeField]
	private GameObject[] _references;

	public override void MStart()
	{
	}
}
