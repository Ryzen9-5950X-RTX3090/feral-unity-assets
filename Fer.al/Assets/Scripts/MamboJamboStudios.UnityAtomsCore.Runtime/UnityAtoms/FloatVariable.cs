using UnityEngine;

namespace UnityAtoms
{
	[CreateAssetMenu]
	[EditorIcon("atom-icon-lush")]
	public sealed class FloatVariable : EquatableAtomVariable<float, FloatEvent, FloatFloatEvent>
	{
		public bool ApplyChange(float amount)
		{
			return default(bool);
		}

		public bool ApplyChange(EquatableAtomVariable<float, FloatEvent, FloatFloatEvent> amount)
		{
			return default(bool);
		}
	}
}
