using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-lush")]
	public sealed class BoolVariable : EquatableAtomVariable<bool, BoolEvent, BoolBoolEvent>
	{
	}
}
