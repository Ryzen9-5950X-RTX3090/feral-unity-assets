using UnityEngine;

namespace UnityAtoms
{
	[AddComponentMenu("Unity Atoms/Listeners/Collider2D x 2 Listener")]
	[EditorIcon("atom-icon-orange")]
	public sealed class Collider2DCollider2DListener : AtomListener<Collider2D, Collider2D, Collider2DCollider2DAction, Collider2DCollider2DEvent, Collider2DCollider2DUnityEvent>
	{
	}
}
