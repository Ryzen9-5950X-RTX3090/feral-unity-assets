using UnityEngine;

namespace UnityAtoms
{
	[AddComponentMenu("Unity Atoms/Listeners/Color Listener")]
	[EditorIcon("atom-icon-orange")]
	public sealed class ColorListener : AtomListener<Color, ColorAction, ColorEvent, ColorUnityEvent>
	{
	}
}
