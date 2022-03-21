using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-piglet")]
	public sealed class ColorList : AtomList<Color, ColorEvent>
	{
	}
}
