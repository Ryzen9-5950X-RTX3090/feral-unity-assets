using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-purple")]
	public sealed class SetBoolVariableValue : SetVariableValue<bool, BoolVariable, BoolConstant, BoolReference, BoolEvent, BoolBoolEvent>
	{
	}
}
