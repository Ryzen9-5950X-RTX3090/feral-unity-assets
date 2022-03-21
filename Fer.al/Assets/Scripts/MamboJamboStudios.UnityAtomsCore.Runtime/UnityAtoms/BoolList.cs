using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-piglet")]
	public sealed class BoolList : AtomList<bool, BoolEvent>
	{
	}
}
