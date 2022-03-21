using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-lush")]
	public sealed class GameObjectVariable : AtomVariable<GameObject, GameObjectEvent, GameObjectGameObjectEvent>
	{
		protected override bool AreEqual(GameObject first, GameObject second)
		{
			return default(bool);
		}
	}
}
