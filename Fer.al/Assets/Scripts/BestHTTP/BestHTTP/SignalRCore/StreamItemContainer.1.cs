using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace BestHTTP.SignalRCore
{
	public sealed class StreamItemContainer<T>
	{
		public readonly long id;

		public bool IsCanceled;

		public List<T> Items
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public T LastAdded
		{
			[CompilerGenerated]
			get
			{
				return (T)null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public StreamItemContainer(long _id)
		{
		}

		public void AddItem(T item)
		{
		}
	}
}
