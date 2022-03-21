using UnityEngine;

namespace UnityAtoms
{
	[AddComponentMenu("Unity Atoms/Listeners/String Listener")]
	[EditorIcon("atom-icon-orange")]
	public sealed class StringListener : AtomListener<string, StringAction, StringEvent, StringUnityEvent>
	{
	}
}
