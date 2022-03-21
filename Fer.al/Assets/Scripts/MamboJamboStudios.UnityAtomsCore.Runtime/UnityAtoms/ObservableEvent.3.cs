using System;
using System.Collections.Generic;

namespace UnityAtoms
{
	internal class ObservableEvent<T1, T2, M> : IObservable<M>
	{
		private Action<Action<T1, T2>> _unregister;

		private List<IObserver<M>> _observers;

		private Func<T1, T2, M> _createCombinedModel;

		public ObservableEvent(Action<Action<T1, T2>> register, Action<Action<T1, T2>> unregister, Func<T1, T2, M> createCombinedModel)
		{
		}

		~ObservableEvent()
		{
		}

		public IDisposable Subscribe(IObserver<M> observer)
		{
			return null;
		}

		private void NotifyObservers(T1 value1, T2 value2)
		{
		}
	}
}
