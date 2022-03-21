using System.Runtime.CompilerServices;

namespace BestHTTP.Extensions
{
	public sealed class CircularBuffer<T>
	{
		private T[] buffer;

		private int startIdx;

		private int endIdx;

		public int Capacity
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

		public int StartIdx
		{
			get
			{
				return default(int);
			}
		}

		public int EndIdx
		{
			get
			{
				return default(int);
			}
		}

		public T this[int idx]
		{
			get
			{
				return (T)null;
			}
			set
			{
			}
		}

		public CircularBuffer(int capacity)
		{
		}

		public void Add(T element)
		{
		}

		public void Clear()
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
