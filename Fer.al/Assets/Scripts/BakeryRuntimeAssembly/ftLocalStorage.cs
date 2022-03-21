using System.Collections.Generic;
using UnityEngine;

public class ftLocalStorage : ScriptableObject
{
	[SerializeField]
	public List<string> modifiedAssetPathList;

	[SerializeField]
	public List<int> modifiedAssetPaddingHash;
}
