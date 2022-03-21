using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal.Util
{
	public class LruList<TKey, TValue>
	{
		public LruListItem<TKey, TValue> Head
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

		public LruListItem<TKey, TValue> Tail
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

		public void Add(LruListItem<TKey, TValue> item)
		{
		}

		public void Remove(LruListItem<TKey, TValue> item)
		{
		}

		public void Touch(LruListItem<TKey, TValue> item)
		{
		}

		public TKey EvictOldest()
		{
			return (TKey)null;
		}

		internal void Clear()
		{
		}
	}
}
