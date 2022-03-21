using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-purple")]
	public sealed class SetColorVariableValue : SetVariableValue<Color, ColorVariable, ColorConstant, ColorReference, ColorEvent, ColorColorEvent>
	{
	}
}
