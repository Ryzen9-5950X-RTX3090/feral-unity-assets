using UnityEngine;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-teal")]
	public abstract class AtomBaseVariable<T> : AtomBaseVariable
	{
		[SerializeField]
		protected T _value;

		public override object BaseValue
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public virtual T Value
		{
			get
			{
				return (T)null;
			}
			set
			{
			}
		}

		protected bool Equals(AtomBaseVariable<T> other)
		{
			return default(bool);
		}

		public override bool Equals(object obj)
		{
			return default(bool);
		}

		public override int GetHashCode()
		{
			return default(int);
		}

		public static bool operator ==(AtomBaseVariable<T> left, AtomBaseVariable<T> right)
		{
			return default(bool);
		}

		public static bool operator !=(AtomBaseVariable<T> left, AtomBaseVariable<T> right)
		{
			return default(bool);
		}

		public override void Reset(bool shouldTriggerEvents = false)
		{
		}
	}
}
