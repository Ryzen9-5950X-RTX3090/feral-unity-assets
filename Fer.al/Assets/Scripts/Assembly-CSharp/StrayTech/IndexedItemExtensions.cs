using System.Collections.Generic;

namespace StrayTech
{
	public static class IndexedItemExtensions
	{
		public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue, TSource>(this List<TSource> toInflate) where TSource : IndexedItem<TKey, TValue>
		{
			return null;
		}
	}
}
