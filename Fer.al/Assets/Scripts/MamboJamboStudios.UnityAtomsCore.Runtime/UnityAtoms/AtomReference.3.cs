using UnityEngine;

namespace UnityAtoms
{
	public abstract class AtomReference<T, V, C> : AtomReference where V : AtomBaseVariable<T> where C : AtomBaseVariable<T>
	{
		[SerializeField]
		private T _value;

		public C _constant;

		public V _variable;

		public T Value
		{
			get
			{
				return (T)null;
			}
			set
			{
			}
		}

		public static implicit operator T(AtomReference<T, V, C> reference)
		{
			return (T)null;
		}
	}
}
