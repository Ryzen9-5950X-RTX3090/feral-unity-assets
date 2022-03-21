using System;
using UnityEngine;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-lush")]
	public abstract class AtomVariable<T, E1, E2> : AtomBaseVariable<T> where E1 : AtomEvent<T> where E2 : AtomEvent<T, T>
	{
		[SerializeField]
		private T _initialValue;

		[SerializeField]
		private T _oldValue;

		public E1 Changed;

		public E2 ChangedWithHistory;

		public override T Value
		{
			get
			{
				return (T)null;
			}
			set
			{
			}
		}

		public T InitialValue
		{
			get
			{
				return (T)null;
			}
		}

		public T OldValue
		{
			get
			{
				return (T)null;
			}
		}

		protected abstract bool AreEqual(T first, T second);

		private void OnEnable()
		{
		}

		public sealed override void Reset(bool shouldTriggerEvents = false)
		{
		}

		public bool SetValue(T newValue)
		{
			return default(bool);
		}

		public bool SetValue(AtomVariable<T, E1, E2> variable)
		{
			return default(bool);
		}

		public IObservable<T> ObserveChange()
		{
			return null;
		}

		public IObservable<ValueTuple<T, T>> ObserveChangeWithHistory()
		{
			return null;
		}
	}
}
