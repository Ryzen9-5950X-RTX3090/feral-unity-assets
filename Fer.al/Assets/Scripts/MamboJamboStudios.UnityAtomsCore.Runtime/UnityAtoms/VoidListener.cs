using UnityEngine;

namespace UnityAtoms
{
	[AddComponentMenu("Unity Atoms/Listeners/Void Listener")]
	[EditorIcon("atom-icon-orange")]
	public sealed class VoidListener : AtomListener<Void, VoidAction, VoidEvent, VoidUnityEvent>
	{
	}
}
