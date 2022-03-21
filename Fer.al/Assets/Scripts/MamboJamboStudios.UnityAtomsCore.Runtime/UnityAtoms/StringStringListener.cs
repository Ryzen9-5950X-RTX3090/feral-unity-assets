using UnityEngine;

namespace UnityAtoms
{
	[AddComponentMenu("Unity Atoms/Listeners/String x 2 Listener")]
	[EditorIcon("atom-icon-orange")]
	public sealed class StringStringListener : AtomListener<string, string, StringStringAction, StringStringEvent, StringStringUnityEvent>
	{
	}
}
