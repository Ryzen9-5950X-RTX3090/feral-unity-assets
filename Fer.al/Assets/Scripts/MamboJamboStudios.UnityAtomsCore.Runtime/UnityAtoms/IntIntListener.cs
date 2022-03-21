using UnityEngine;

namespace UnityAtoms
{
	[AddComponentMenu("Unity Atoms/Listeners/Int x 2 Listener")]
	[EditorIcon("atom-icon-orange")]
	public sealed class IntIntListener : AtomListener<int, int, IntIntAction, IntIntEvent, IntIntUnityEvent>
	{
	}
}
