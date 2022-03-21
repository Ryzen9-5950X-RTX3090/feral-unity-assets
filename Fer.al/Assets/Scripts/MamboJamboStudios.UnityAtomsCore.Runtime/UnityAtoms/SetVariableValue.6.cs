using UnityEngine;

namespace UnityAtoms
{
	public abstract class SetVariableValue<T, V, E1, E2, C, R> : VoidAction where V : AtomVariable<T, E1, E2> where E1 : AtomEvent<T> where E2 : AtomEvent<T, T> where C : AtomBaseVariable<T> where R : AtomReference<T, V, C>
	{
		[SerializeField]
		private V _variable;

		[SerializeField]
		private R _value;

		public override void Do()
		{
		}
	}
}
