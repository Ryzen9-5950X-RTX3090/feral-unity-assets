using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-lush")]
	public sealed class IntVariable : EquatableAtomVariable<int, IntEvent, IntIntEvent>
	{
		public bool ApplyChange(int amount)
		{
			return default(bool);
		}

		public bool ApplyChange(EquatableAtomVariable<int, IntEvent, IntIntEvent> amount)
		{
			return default(bool);
		}
	}
}
