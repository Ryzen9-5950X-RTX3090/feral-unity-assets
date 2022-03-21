using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-piglet")]
	public sealed class IntList : AtomList<int, IntEvent>
	{
	}
}
