using UnityEngine;

namespace UnityAtoms
{
	[AddComponentMenu("Unity Atoms/Listeners/Float x 2 Listener")]
	[EditorIcon("atom-icon-orange")]
	public sealed class FloatFloatListener : AtomListener<float, float, FloatFloatAction, FloatFloatEvent, FloatFloatUnityEvent>
	{
	}
}
