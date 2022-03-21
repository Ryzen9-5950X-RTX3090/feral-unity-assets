using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-purple")]
	public sealed class SetGameObjectVariableValue : SetVariableValue<GameObject, GameObjectVariable, GameObjectConstant, GameObjectReference, GameObjectEvent, GameObjectGameObjectEvent>
	{
	}
}
