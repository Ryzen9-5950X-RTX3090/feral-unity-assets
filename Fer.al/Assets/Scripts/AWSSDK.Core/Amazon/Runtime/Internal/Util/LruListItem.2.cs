using System.Runtime.CompilerServices;

namespace Amazon.Runtime.Internal.Util
{
	public class LruListItem<TKey, TValue>
	{
		public TValue Value
		{
			[CompilerGenerated]
			get
			{
				return (TValue)null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public TKey Key
		{
			[CompilerGenerated]
			get
			{
				return (TKey)null;
			}
			[CompilerGenerated]
			private set
			{
			}
		}

		public LruListItem<TKey, TValue> Next
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public LruListItem<TKey, TValue> Previous
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public LruListItem(TKey key, TValue value)
		{
		}
	}
}
