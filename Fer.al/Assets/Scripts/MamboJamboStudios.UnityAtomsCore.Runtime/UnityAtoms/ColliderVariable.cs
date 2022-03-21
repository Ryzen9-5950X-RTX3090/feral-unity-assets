using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-lush")]
	public sealed class ColliderVariable : AtomVariable<Collider, ColliderEvent, ColliderColliderEvent>
	{
		protected override bool AreEqual(Collider first, Collider second)
		{
			return default(bool);
		}
	}
}
