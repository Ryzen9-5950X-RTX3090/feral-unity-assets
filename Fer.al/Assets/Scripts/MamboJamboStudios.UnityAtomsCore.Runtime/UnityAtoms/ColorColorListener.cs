using UnityEngine;

namespace UnityAtoms
{
	[AddComponentMenu("Unity Atoms/Listeners/Color x 2 Listener")]
	[EditorIcon("atom-icon-orange")]
	public sealed class ColorColorListener : AtomListener<Color, Color, ColorColorAction, ColorColorEvent, ColorColorUnityEvent>
	{
	}
}
