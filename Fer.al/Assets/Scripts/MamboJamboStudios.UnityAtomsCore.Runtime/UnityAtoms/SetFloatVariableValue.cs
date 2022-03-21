using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-purple")]
	public sealed class SetFloatVariableValue : SetVariableValue<float, FloatVariable, FloatConstant, FloatReference, FloatEvent, FloatFloatEvent>
	{
	}
}
