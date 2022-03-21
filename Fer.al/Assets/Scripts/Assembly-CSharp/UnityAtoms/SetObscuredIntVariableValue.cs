using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-purple")]
	public sealed class SetObscuredIntVariableValue : SetVariableValue<ObscuredInt, ObscuredIntVariable, ObscuredIntConstant, ObscuredIntReference, ObscuredIntEvent, ObscuredIntObscuredIntEvent>
	{
	}
}
