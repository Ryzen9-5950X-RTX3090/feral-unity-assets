using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-lush")]
	public sealed class ColorVariable : EquatableAtomVariable<Color, ColorEvent, ColorColorEvent>
	{
	}
}
