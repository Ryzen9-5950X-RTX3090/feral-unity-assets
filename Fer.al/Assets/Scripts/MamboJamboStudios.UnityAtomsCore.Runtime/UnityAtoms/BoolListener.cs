using UnityEngine;

namespace UnityAtoms
{
	[AddComponentMenu("Unity Atoms/Listeners/Bool Listener")]
	[EditorIcon("atom-icon-orange")]
	public sealed class BoolListener : AtomListener<bool, BoolAction, BoolEvent, BoolUnityEvent>
	{
	}
}
