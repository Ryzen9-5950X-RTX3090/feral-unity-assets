using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace Candlelight
{
	internal class ObjectPool<T> where T : new()
	{
		private readonly Stack<T> m_Stack;

		private readonly Action<T> m_ActionOnGet;

		private readonly Action<T> m_ActionOnRelease;

		public int Count
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public int CountActive
		{
			get
			{
				return default(int);
			}
		}

		public int CountInactive
		{
			get
			{
				return default(int);
			}
		}

		public ObjectPool(Action<T> actionOnGet, Action<T> actionOnRelease)
		{
		}

		public T Get()
		{
			return (T)null;
		}

		public void Release(T element)
		{
		}
	}
}
