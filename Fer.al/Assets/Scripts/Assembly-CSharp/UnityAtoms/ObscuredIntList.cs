using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-piglet")]
	public sealed class ObscuredIntList : AtomList<ObscuredInt, ObscuredIntEvent>
	{
	}
}
