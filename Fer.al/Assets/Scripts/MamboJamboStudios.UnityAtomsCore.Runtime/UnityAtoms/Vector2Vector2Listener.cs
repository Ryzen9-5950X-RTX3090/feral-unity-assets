using UnityEngine;

namespace UnityAtoms
{
	[AddComponentMenu("Unity Atoms/Listeners/Vector2 x 2 Listener")]
	[EditorIcon("atom-icon-orange")]
	public sealed class Vector2Vector2Listener : AtomListener<Vector2, Vector2, Vector2Vector2Action, Vector2Vector2Event, Vector2Vector2UnityEvent>
	{
	}
}
