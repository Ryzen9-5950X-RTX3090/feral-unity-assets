using UnityEngine;

namespace UnityAtoms
{
	[AddComponentMenu("Unity Atoms/Listeners/Int Listener")]
	[EditorIcon("atom-icon-orange")]
	public sealed class IntListener : AtomListener<int, IntAction, IntEvent, IntUnityEvent>
	{
	}
}
