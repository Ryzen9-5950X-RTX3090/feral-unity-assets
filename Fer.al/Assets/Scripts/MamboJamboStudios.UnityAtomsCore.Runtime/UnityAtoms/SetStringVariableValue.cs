using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-purple")]
	public sealed class SetStringVariableValue : SetVariableValue<string, StringVariable, StringConstant, StringReference, StringEvent, StringStringEvent>
	{
	}
}
