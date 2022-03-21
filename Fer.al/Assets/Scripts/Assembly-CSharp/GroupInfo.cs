using UnityEngine;

public class GroupInfo : MonoBehaviour
{
	[Tooltip("This will be auto-populated when exporting WorldObjects for this scene")]
	public string uuid;

	[Tooltip("GroupCount may represent different things in different contexts, but for now just means the maxSpawnLimit")]
	public int groupCount;
}
