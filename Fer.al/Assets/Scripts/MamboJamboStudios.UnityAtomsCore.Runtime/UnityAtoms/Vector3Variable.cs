using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-lush")]
	public sealed class Vector3Variable : EquatableAtomVariable<Vector3, Vector3Event, Vector3Vector3Event>
	{
	}
}
