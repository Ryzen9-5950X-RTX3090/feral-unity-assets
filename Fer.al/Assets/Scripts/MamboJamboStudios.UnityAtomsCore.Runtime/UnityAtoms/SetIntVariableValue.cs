using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-purple")]
	public sealed class SetIntVariableValue : SetVariableValue<int, IntVariable, IntConstant, IntReference, IntEvent, IntIntEvent>
	{
	}
}
