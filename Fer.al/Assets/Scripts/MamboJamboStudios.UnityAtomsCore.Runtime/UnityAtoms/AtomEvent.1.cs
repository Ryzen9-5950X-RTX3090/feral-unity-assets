using System;
using System.Runtime.CompilerServices;

namespace UnityAtoms
{
	[EditorIcon("atom-icon-cherry")]
	public abstract class AtomEvent<T> : AtomEvent
	{
		public event Action<T> OnEvent
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

		public void Raise(T item)
		{
		}

		public void Register(Action<T> del)
		{
		}

		public void Unregister(Action<T> del)
		{
		}

		public void RegisterListener(IAtomListener<T> listener)
		{
		}

		public void UnregisterListener(IAtomListener<T> listener)
		{
		}

		public IObservable<T> Observe()
		{
			return null;
		}

		public override void OnAfterDeserialize()
		{
		}
	}
}
