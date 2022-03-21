using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-lush")]
	public sealed class ObscuredIntVariable : EquatableAtomVariable<ObscuredInt, ObscuredIntEvent, ObscuredIntObscuredIntEvent>
	{
	}
}
