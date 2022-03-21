namespace UniRx.Async.Internal
{
	internal class ImmutableList<T>
	{
		public static readonly ImmutableList<T> Empty;

		private T[] data;

		public T[] Data
		{
			get
			{
				return null;
			}
		}

		private ImmutableList()
		{
		}

		public ImmutableList(T[] data)
		{
		}

		public ImmutableList<T> Add(T value)
		{
			return null;
		}

		public ImmutableList<T> Remove(T value)
		{
			return null;
		}

		public int IndexOf(T value)
		{
			return default(int);
		}
	}
}
