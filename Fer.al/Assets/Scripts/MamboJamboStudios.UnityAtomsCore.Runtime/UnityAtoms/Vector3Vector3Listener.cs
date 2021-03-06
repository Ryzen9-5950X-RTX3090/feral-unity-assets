using UnityEngine;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-orange")]
	[AddComponentMenu("Unity Atoms/Listeners/Vector3 x 2 Listener")]
	public sealed class Vector3Vector3Listener : AtomListener<Vector3, Vector3, Vector3Vector3Action, Vector3Vector3Event, Vector3Vector3UnityEvent>
	{
	}
}
