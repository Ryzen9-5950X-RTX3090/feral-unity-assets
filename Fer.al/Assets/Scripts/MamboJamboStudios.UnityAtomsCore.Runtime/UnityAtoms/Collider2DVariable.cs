using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-lush")]
	public sealed class Collider2DVariable : AtomVariable<Collider2D, Collider2DEvent, Collider2DCollider2DEvent>
	{
		protected override bool AreEqual(Collider2D first, Collider2D second)
		{
			return default(bool);
		}
	}
}
