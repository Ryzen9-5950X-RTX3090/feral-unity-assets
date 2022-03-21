using System;
using System.Collections.Generic;

namespace UnityAtoms
{
	internal class ObservableUnsubscriber<T> : IDisposable
	{
		private List<IObserver<T>> _observers;

		private IObserver<T> _observer;

		public ObservableUnsubscriber(List<IObserver<T>> observers, IObserver<T> observer)
		{
		}

		public void Dispose()
		{
		}
	}
}
