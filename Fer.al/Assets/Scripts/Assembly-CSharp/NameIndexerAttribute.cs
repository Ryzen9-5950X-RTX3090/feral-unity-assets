using UnityEngine;

public class NameIndexerAttribute : PropertyAttribute
{
	public string baseName;

	public bool zeroBasedIndex;

	public NameIndexerAttribute(string inName, bool inZeroBasedIndex)
	{
	}
}
