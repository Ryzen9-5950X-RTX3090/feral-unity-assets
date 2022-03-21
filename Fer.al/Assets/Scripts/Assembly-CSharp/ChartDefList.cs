using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public class ChartDefList : IEnumerable<BaseDef>, IEnumerable
{
	[SerializeField]
	private List<string> _defIDs;

	[NonSerialized]
	private List<BaseDef> _defs;

	public List<string> DefIDs
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public List<BaseDef> Defs
	{
		get
		{
			return null;
		}
	}

	public int Count
	{
		get
		{
			return default(int);
		}
	}

	public BaseDef this[int inIndex]
	{
		get
		{
			return null;
		}
	}

	public List<T> DefComponents<T>() where T : DefComponent
	{
		return null;
	}

	[IteratorStateMachine(typeof(<GetEnumerator>d__8))]
	public IEnumerator<BaseDef> GetEnumerator()
	{
		return null;
	}

	IEnumerator IEnumerable.GetEnumerator()
	{
		return null;
	}

	public ChartDefList()
	{
	}

	public ChartDefList(List<string> inDefIds)
	{
	}
}
