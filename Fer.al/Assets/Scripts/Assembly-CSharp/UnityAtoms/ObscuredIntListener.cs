using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-orange")]
	[AddComponentMenu("Unity Atoms/Listeners/ObscuredInt Listener")]
	public sealed class ObscuredIntListener : AtomListener<ObscuredInt, ObscuredIntAction, ObscuredIntEvent, ObscuredIntUnityEvent>
	{
	}
}
