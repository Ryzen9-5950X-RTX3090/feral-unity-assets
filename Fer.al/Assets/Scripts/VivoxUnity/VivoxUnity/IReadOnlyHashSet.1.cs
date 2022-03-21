using System;

namespace VivoxUnity
{
	public interface IReadOnlyHashSet<T>
	{
		int Count { get; }

		event EventHandler<KeyEventArg<T>> AfterKeyAdded;

		event EventHandler<KeyEventArg<T>> BeforeKeyRemoved;

		bool Contains(T key);
	}
}
