using UnityEngine;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-orange")]
	[AddComponentMenu("Unity Atoms/Listeners/Collider Listener")]
	public sealed class ColliderListener : AtomListener<Collider, ColliderAction, ColliderEvent, ColliderUnityEvent>
	{
	}
}
