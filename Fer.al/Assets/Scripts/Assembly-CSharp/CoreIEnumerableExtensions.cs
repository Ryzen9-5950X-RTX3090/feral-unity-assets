using System;
using System.Collections;
using System.Collections.Generic;

public static class CoreIEnumerableExtensions
{
	public static IEnumerable<T> ForEach<T>(this IEnumerable<T> inIEnumerable, Action<T> inResult)
	{
		return null;
	}

	public static IEnumerable<T> ForEach<T>(this IEnumerable<T> inIEnumerable, Action<int, T> inResult)
	{
		return null;
	}

	public static IEnumerable ForEach(this IEnumerable inIEnumerable, Action<object> inResult)
	{
		return null;
	}

	public static IEnumerable ForEach(this IEnumerable inIEnumerable, Action<int, object> inResult)
	{
		return null;
	}
}
