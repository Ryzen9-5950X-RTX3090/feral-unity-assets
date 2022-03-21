using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-lush")]
	public sealed class StringVariable : EquatableAtomVariable<string, StringEvent, StringStringEvent>
	{
	}
}
