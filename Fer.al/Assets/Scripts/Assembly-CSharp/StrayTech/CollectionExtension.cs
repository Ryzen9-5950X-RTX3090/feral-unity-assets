using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace StrayTech
{
	public static class CollectionExtension
	{
		public static void AddOrSet<TKey, TValue>(this Dictionary<TKey, TValue> self, TKey key, TValue value)
		{
		}

		public static int WrapIndex(this ICollection self, int index)
		{
			return default(int);
		}

		public static int WrapIndex(int index, int collectionCount)
		{
			return default(int);
		}

		public static int ClampIndex(this ICollection self, int index)
		{
			return default(int);
		}

		public static T GetRandomElement<T>(this List<T> self)
		{
			return (T)null;
		}

		public static T GetRandomElement<T>(this HashSet<T> self)
		{
			return (T)null;
		}

		public static T GetRandomElement<T>(this IEnumerable<T> self)
		{
			return (T)null;
		}

		public static List<T> GenerateListWithValues<T>(T value, int count)
		{
			return null;
		}

		public static void Shuffle<T>(this T[] self)
		{
		}

		[IteratorStateMachine(typeof(<ScrapeValidItems>d__9<>))]
		public static IEnumerable<T> ScrapeValidItems<T>(this IEnumerable<T> self) where T : IValidates
		{
			return null;
		}

		public static HashSet<T> ScrapeValidAndUniqueItems<T>(this IEnumerable<T> self) where T : IValidates
		{
			return null;
		}

		[IteratorStateMachine(typeof(<ScrapeNonNullAndUniqueItems>d__11<>))]
		public static IEnumerable<T> ScrapeNonNullAndUniqueItems<T>(this IEnumerable<T> self)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<ScrapeNonNullItems>d__12<>))]
		public static IEnumerable<T> ScrapeNonNullItems<T>(this IEnumerable<T> self) where T : class
		{
			return null;
		}

		public static Dictionary<TKey, TValue> ToDictionary<TKey, TValue, TSelf>(this TSelf self) where TSelf : List<IndexedItem<TKey, TValue>>
		{
			return null;
		}

		public static T ElementAtSafe<T>(this List<T> self, int index)
		{
			return (T)null;
		}

		public static bool IsNullOrEmpty(this ICollection self)
		{
			return default(bool);
		}

		[IteratorStateMachine(typeof(<ToEnumerable>d__16<>))]
		public static IEnumerable<T> ToEnumerable<T>(this T item)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<Field>d__17<, >))]
		public static IEnumerable<TField> Field<TField, TSource>(this IEnumerable<TSource> source, Func<TSource, TField> fieldExtractor)
		{
			return null;
		}

		public static void Remove<T>(this T[] self, T toRemove) where T : class
		{
		}

		public static T FirstOrDefaultQuick<T>(this List<T> self)
		{
			return (T)null;
		}

		public static T[] Subset<T>(this T[] source, int length)
		{
			return null;
		}

		public static void PreallocateCapacity(this HashSet<int> toPopulate, int capacity)
		{
		}

		public static void AddSubsetToSelf<T>(this List<T> self, int startIndex, int count)
		{
		}

		public static void AddSubsetFromOther<T>(this List<T> self, List<T> other, int startIndex, int count)
		{
		}
	}
}
