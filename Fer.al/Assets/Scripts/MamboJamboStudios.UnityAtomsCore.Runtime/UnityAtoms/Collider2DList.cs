using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-piglet")]
	public sealed class Collider2DList : AtomList<Collider2D, Collider2DEvent>
	{
	}
}
