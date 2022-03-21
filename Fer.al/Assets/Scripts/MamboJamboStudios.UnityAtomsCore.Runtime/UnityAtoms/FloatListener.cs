using UnityEngine;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-orange")]
	[AddComponentMenu("Unity Atoms/Listeners/Float Listener")]
	public sealed class FloatListener : AtomListener<float, FloatAction, FloatEvent, FloatUnityEvent>
	{
	}
}
