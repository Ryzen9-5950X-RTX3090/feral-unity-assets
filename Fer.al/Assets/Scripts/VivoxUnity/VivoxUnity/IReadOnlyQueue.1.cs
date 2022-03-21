using System;

namespace VivoxUnity
{
	public interface IReadOnlyQueue<T>
	{
		int Count { get; }

		event EventHandler<QueueItemAddedEventArgs<T>> AfterItemAdded;

		T Dequeue();

		void Clear();

		T Peek();
	}
}
