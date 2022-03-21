using UnityEngine;

namespace UnityAtoms
{
	[AddComponentMenu("Unity Atoms/Listeners/Bool x 2 Listener")]
	[EditorIcon("atom-icon-orange")]
	public sealed class BoolBoolListener : AtomListener<bool, bool, BoolBoolAction, BoolBoolEvent, BoolBoolUnityEvent>
	{
	}
}
