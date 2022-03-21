using UnityEngine;

namespace UnityAtoms
{
	[AddComponentMenu("Unity Atoms/Listeners/Collider x 2 Listener")]
	[EditorIcon("atom-icon-orange")]
	public sealed class ColliderColliderListener : AtomListener<Collider, Collider, ColliderColliderAction, ColliderColliderEvent, ColliderColliderUnityEvent>
	{
	}
}
