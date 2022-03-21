using System.Runtime.CompilerServices;

namespace Newtonsoft.Json.Utilities
{
	[IsReadOnly]
	internal struct StringReference
	{
		private readonly char[] _chars;

		private readonly int _startIndex;

		private readonly int _length;

		public char this[int i]
		{
			get
			{
				return default(char);
			}
		}

		public char[] Chars
		{
			get
			{
				return null;
			}
		}

		public int StartIndex
		{
			get
			{
				return default(int);
			}
		}

		public int Length
		{
			get
			{
				return default(int);
			}
		}

		public StringReference(char[] chars, int startIndex, int length)
		{
		}

		public override string ToString()
		{
			return null;
		}
	}
}
