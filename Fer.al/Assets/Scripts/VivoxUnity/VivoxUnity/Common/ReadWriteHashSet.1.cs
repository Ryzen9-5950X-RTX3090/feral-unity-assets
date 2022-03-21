using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Common
{
	internal class ReadWriteHashSet<T> : IReadOnlyHashSet<T>
	{
		private readonly HashSet<T> _items;

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public event EventHandler<KeyEventArg<T>> AfterKeyAdded
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

		public event EventHandler<KeyEventArg<T>> BeforeKeyRemoved
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

		public bool Contains(T key)
		{
			return default(bool);
		}

		public bool Add(T key)
		{
			return default(bool);
		}

		public bool Remove(T key)
		{
			return default(bool);
		}

		public void Clear()
		{
		}
	}
}
