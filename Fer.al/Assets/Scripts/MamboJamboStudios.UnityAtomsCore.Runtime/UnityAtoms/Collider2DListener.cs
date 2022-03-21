using UnityEngine;

namespace UnityAtoms
{
	[AddComponentMenu("Unity Atoms/Listeners/Collider2D Listener")]
	[EditorIcon("atom-icon-orange")]
	public sealed class Collider2DListener : AtomListener<Collider2D, Collider2DAction, Collider2DEvent, Collider2DUnityEvent>
	{
	}
}
