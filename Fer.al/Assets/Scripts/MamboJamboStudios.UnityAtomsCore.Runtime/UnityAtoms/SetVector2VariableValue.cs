using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-purple")]
	public sealed class SetVector2VariableValue : SetVariableValue<Vector2, Vector2Variable, Vector2Constant, Vector2Reference, Vector2Event, Vector2Vector2Event>
	{
	}
}
