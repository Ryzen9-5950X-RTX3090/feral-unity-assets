using System;
using System.Collections.Generic;

namespace UnityAtoms
{
	internal class ObservableEvent<T> : IObservable<T>
	{
		private Action<Action<T>> _unregister;

		private List<IObserver<T>> _observers;

		public ObservableEvent(Action<Action<T>> register, Action<Action<T>> unregister)
		{
		}

		~ObservableEvent()
		{
		}

		public IDisposable Subscribe(IObserver<T> observer)
		{
			return null;
		}

		private void NotifyObservers(T value)
		{
		}
	}
}
