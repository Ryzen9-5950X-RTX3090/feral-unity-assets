using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-piglet")]
	public sealed class GameObjectList : AtomList<GameObject, GameObjectEvent>
	{
	}
}
