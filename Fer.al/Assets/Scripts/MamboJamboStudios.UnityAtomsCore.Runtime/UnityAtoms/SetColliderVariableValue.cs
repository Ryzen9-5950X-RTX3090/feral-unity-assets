using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-purple")]
	public sealed class SetColliderVariableValue : SetVariableValue<Collider, ColliderVariable, ColliderConstant, ColliderReference, ColliderEvent, ColliderColliderEvent>
	{
	}
}
