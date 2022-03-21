using System;
using System.Collections.Generic;

public static class CoreDictionaryExtensions
{
	public static bool IsNullOrEmpty<T, U>(this Dictionary<T, U> inDict)
	{
		return default(bool);
	}

	public static bool IsEqual<T, U>(this Dictionary<T, U> inDict1, Dictionary<T, U> inDict2, Func<U, U, bool> inEqualityFunc)
	{
		return default(bool);
	}

	public static void CopyOver<T, U>(this Dictionary<T, U> inDict1, Dictionary<T, U> inDict2)
	{
	}

	public static U GetExistingEntryOrNull<U, T>(this Dictionary<T, U> inDict, T inKey) where U : class
	{
		return null;
	}

	public static void ForEach<TKey, TValue>(this Dictionary<TKey, TValue> inDict, Action<TKey, TValue> inAction)
	{
	}

	public static void ForEachValue<TKey, TValue>(this Dictionary<TKey, TValue> inDict, Action<TValue> inAction)
	{
	}
}
