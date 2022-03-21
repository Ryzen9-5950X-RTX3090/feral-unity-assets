using System;
using System.Collections;
using System.Collections.Generic;

namespace VivoxUnity
{
	public interface IReadOnlyDictionary<TK, T> : IEnumerable<T>, IEnumerable
	{
		ICollection<TK> Keys { get; }

		T this[TK key] { get; }

		int Count { get; }

		event EventHandler<KeyEventArg<TK>> AfterKeyAdded;

		event EventHandler<KeyEventArg<TK>> BeforeKeyRemoved;

		event EventHandler<ValueEventArg<TK, T>> AfterValueUpdated;

		bool ContainsKey(TK key);
	}
}
