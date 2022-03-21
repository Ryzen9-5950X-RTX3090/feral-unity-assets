namespace Newtonsoft.Json.Utilities
{
	internal struct StringBuffer
	{
		private char[] _buffer;

		private int _position;

		public int Position
		{
			get
			{
				return default(int);
			}
			set
			{
			}
		}

		public bool IsEmpty
		{
			get
			{
				return default(bool);
			}
		}

		public char[] InternalBuffer
		{
			get
			{
				return null;
			}
		}

		public StringBuffer(IArrayPool<char> bufferPool, int initalSize)
		{
		}

		private StringBuffer(char[] buffer)
		{
		}

		public void Append(IArrayPool<char> bufferPool, char value)
		{
		}

		public void Append(IArrayPool<char> bufferPool, char[] buffer, int startIndex, int count)
		{
		}

		public void Clear(IArrayPool<char> bufferPool)
		{
		}

		private void EnsureSize(IArrayPool<char> bufferPool, int appendLength)
		{
		}

		public override string ToString()
		{
			return null;
		}

		public string ToString(int start, int length)
		{
			return null;
		}
	}
}
