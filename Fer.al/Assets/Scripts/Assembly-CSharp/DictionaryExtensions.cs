using System.Collections.Generic;

public static class DictionaryExtensions
{
	public static bool TryAdd<T, U>(this IDictionary<T, U> dictionary, T key, U value)
	{
		return default(bool);
	}
}
