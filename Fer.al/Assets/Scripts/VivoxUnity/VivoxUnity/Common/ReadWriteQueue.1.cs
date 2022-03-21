using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Common
{
	public sealed class ReadWriteQueue<T> : IReadOnlyQueue<T>
	{
		private readonly List<T> _items;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public event EventHandler<QueueItemAddedEventArgs<T>> AfterItemAdded
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

		public T Dequeue()
		{
			return (T)null;
		}

		public void Clear()
		{
		}

		public T Peek()
		{
			return (T)null;
		}

		public void Enqueue(T item)
		{
		}

		public bool Contains(T item)
		{
			return default(bool);
		}

		public int RemoveAll(T item)
		{
			return default(int);
		}
	}
}
