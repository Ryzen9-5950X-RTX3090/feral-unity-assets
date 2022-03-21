using System.Collections.Generic;
using UnityEngine;

public class MultiBundle : MonoBehaviour
{
	public List<MultiBundleEntry> assets;

	public T GetAsset<T>(string inBundleID) where T : Object
	{
		return null;
	}
}
