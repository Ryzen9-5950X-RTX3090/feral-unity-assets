using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace VivoxUnity.Common
{
	public sealed class ReadWriteDictionary<TK, TI, T> : IReadOnlyDictionary<TK, TI>, IEnumerable<TI>, IEnumerable where TI : IKeyedItemNotifyPropertyChanged<TK> where T : class, TI
	{
		private readonly Dictionary<TK, TI> _items;

		public TI this[TK key]
		{
			get
			{
				return (TI)null;
			}
			set
			{
			}
		}

		public ICollection<TK> Keys
		{
			get
			{
				return null;
			}
		}

		public int Count
		{
			get
			{
				return default(int);
			}
		}

		public event EventHandler<KeyEventArg<TK>> AfterKeyAdded
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

		public event EventHandler<ValueEventArg<TK, TI>> AfterValueUpdated
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

		public event EventHandler<KeyEventArg<TK>> BeforeKeyRemoved
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

		private void Value_PropertyChanged(object sender, PropertyChangedEventArgs e)
		{
		}

		public void Clear()
		{
		}

		public bool ContainsKey(TK key)
		{
			return default(bool);
		}

		public bool Remove(TK key)
		{
			return default(bool);
		}

		public T At(TK key)
		{
			return null;
		}

		public bool ContainsValue(T item)
		{
			return default(bool);
		}

		public IEnumerator<TI> GetEnumerator()
		{
			return null;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return null;
		}
	}
}
