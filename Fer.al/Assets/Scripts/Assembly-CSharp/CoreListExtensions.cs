using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public static class CoreListExtensions
{
	public static T SafeFind<T>(this List<T> inList, Func<T, bool> inFunc)
	{
		return (T)null;
	}

	public static bool IsNullOrEmpty<T>(this List<T> inList)
	{
		return default(bool);
	}

	public static bool AddIfAbsent<T>(this List<T> inList, T inValue)
	{
		return default(bool);
	}

	public static T GetExistingEntryOrNull<T>(this List<T> inList, T inValue) where T : class
	{
		return null;
	}

	public static T GetRandom<T>(this List<T> inList)
	{
		return (T)null;
	}

	public static T RemoveRandomOrDefault<T>(this List<T> inList)
	{
		return (T)null;
	}

	public static T RemoveRandom<T>(this List<T> inList)
	{
		return (T)null;
	}

	private static T RemoveRandom<T>(this List<T> inList, bool isErrorTolerant)
	{
		return (T)null;
	}

	public static void AddRange<T>(this List<T> input, T[] values)
	{
	}

	public static List<T> GetWhenTrue<T>(this List<T> inList, Func<T, bool> inFunc)
	{
		return null;
	}

	public static T GetLastItem<T>(this List<T> inList)
	{
		return (T)null;
	}

	public static bool IndexInRange<T>(this List<T> inList, int inIndex)
	{
		return default(bool);
	}

	public static void Shuffle<T>(this List<T> inList)
	{
	}

	public static void Shuffle<T>(this List<T> inList, ref UnityEngine.Random.State randomState)
	{
	}

	public static void Shuffle<T>(this List<T> inList, ref System.Random inRandom)
	{
	}

	[IteratorStateMachine(typeof(<FastReverse>d__15<>))]
	public static IEnumerable<T> FastReverse<T>(this IList<T> items)
	{
		return null;
	}

	public static bool InRange(this IList list, int inIndex)
	{
		return default(bool);
	}

	public static void MoveElement(this IList list, int fromIndex, int toIndex)
	{
	}
}
