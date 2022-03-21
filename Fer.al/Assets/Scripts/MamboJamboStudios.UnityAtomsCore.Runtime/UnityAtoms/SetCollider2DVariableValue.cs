using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-purple")]
	public sealed class SetCollider2DVariableValue : SetVariableValue<Collider2D, Collider2DVariable, Collider2DConstant, Collider2DReference, Collider2DEvent, Collider2DCollider2DEvent>
	{
	}
}
