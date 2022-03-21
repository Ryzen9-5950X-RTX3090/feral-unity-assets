using System.Collections.Generic;
using UnityEngine;

public class PersistentAtomController : MonoBehaviour
{
	[SerializeField]
	private CachedUserVar _userVar;

	public List<PersistentAtomData_Int> intVariables;

	public void LoadAtomVariables()
	{
	}

	public void SaveAtomVariables()
	{
	}
}
