using System.Collections.Generic;

namespace Candlelight
{
	public static class BackingFieldUtility<T> where T : IPropertyBackingFieldCompatible
	{
		public class CollectionComparer : IEqualityComparer<T>
		{
			public bool Equals(T a, T b)
			{
				return default(bool);
			}

			public int GetHashCode(T obj)
			{
				return default(int);
			}
		}

		private static CollectionComparer s_Comparer;

		public static CollectionComparer Comparer
		{
			get
			{
				return null;
			}
		}
	}
}
