namespace UniRx.Async.Internal
{
	internal class MinimumQueue<T>
	{
		private const int MinimumGrow = 4;

		private const int GrowFactor = 200;

		private T[] array;

		private int head;

		private int tail;

		private int size;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public MinimumQueue(int capacity)
		{
		}

		public T Peek()
		{
			return (T)null;
		}

		public void Enqueue(T item)
		{
		}

		public T Dequeue()
		{
			return (T)null;
		}

		private void Grow()
		{
		}

		private void SetCapacity(int capacity)
		{
		}

		private void MoveNext(ref int index)
		{
		}

		private void ThrowForEmptyQueue()
		{
		}
	}
}
