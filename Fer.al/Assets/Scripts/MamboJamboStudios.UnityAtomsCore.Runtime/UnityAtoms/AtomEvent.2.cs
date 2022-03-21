using System;
using System.Runtime.CompilerServices;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-cherry")]
	public abstract class AtomEvent<T1, T2> : AtomEvent
	{
		public event Action<T1, T2> OnEvent
		{
			[CompilerGenerated]
			add
			{
			}
			[CompilerGenerated]
			remove
			{
			}
		}

		public void Raise(T1 item1, T2 item2)
		{
		}

		public void Register(Action<T1, T2> del)
		{
		}

		public void Unregister(Action<T1, T2> del)
		{
		}

		public void RegisterListener(IAtomListener<T1, T2> listener)
		{
		}

		public void UnregisterListener(IAtomListener<T1, T2> listener)
		{
		}

		public IObservable<M> Observe<M>(Func<T1, T2, M> resultSelector)
		{
			return null;
		}

		public override void OnAfterDeserialize()
		{
		}
	}
}
