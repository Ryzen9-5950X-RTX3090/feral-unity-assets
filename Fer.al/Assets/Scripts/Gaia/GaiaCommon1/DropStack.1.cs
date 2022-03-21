using System;
using System.Collections.Generic;
using UnityEngine;

namespace GaiaCommon1
{
	[Serializable]
	public class DropStack<T>
	{
		[SerializeField]
		private T[] m_items;

		[SerializeField]
		private int m_topIndex;

		[SerializeField]
		private int m_count;

		public int Capacity
		{
			get
			{
				return default(int);
			}
		}

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public DropStack(int capacity)
		{
		}

		public void Push(T item)
		{
		}

		public void Push(IEnumerable<T> items)
		{
		}

		public T Pop()
		{
			return (T)null;
		}

		public T Peek()
		{
			return (T)null;
		}
	}
}
