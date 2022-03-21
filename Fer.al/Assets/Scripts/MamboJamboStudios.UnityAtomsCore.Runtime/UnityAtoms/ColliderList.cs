using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-piglet")]
	public sealed class ColliderList : AtomList<Collider, ColliderEvent>
	{
	}
}
