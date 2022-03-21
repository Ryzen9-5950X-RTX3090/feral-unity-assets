namespace Gaia.FullSerializer.Internal
{
	public struct fsOption<T>
	{
		private bool _hasValue;

		private T _value;

		public static fsOption<T> Empty;

		public bool HasValue
		{
			get
			{
				return default(bool);
			}
		}

		public bool IsEmpty
		{
			get
			{
				return default(bool);
			}
		}

		public T Value
		{
			get
			{
				return (T)null;
			}
		}

		public fsOption(T value)
		{
		}
	}
}
