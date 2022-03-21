using NodeCanvas.Framework;
using UnityEngine;

public class SocialExpanseInteractedObject : MonoBehaviour
{
	[Tooltip("Link this to the networked object to be marked 'locked'")]
	public NetworkedObjectInfo networkObjectInfo;

	[Tooltip("Link this to the graph of actions to perform when the scene is loaded and the networked object above has already been 'unlocked'")]
	public GraphOwner graphOwner;

	public Interactable.EItemType itemType;

	private bool _expanseStarted;

	private void Start()
	{
	}
}
