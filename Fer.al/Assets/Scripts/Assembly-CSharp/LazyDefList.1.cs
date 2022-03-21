using System;
using System.Collections.Generic;

public class LazyDefList<T> where T : BaseDef
{
	private Func<List<string>, List<T>> _getFunc;

	private List<string> _defIDs;

	private List<T> _defs;

	public List<string> DefIDs
	{
		get
		{
			return null;
		}
	}

	public List<T> Defs
	{
		get
		{
			return null;
		}
	}

	public static implicit operator List<T>(LazyDefList<T> inDef)
	{
		return null;
	}

	public static implicit operator List<string>(LazyDefList<T> inDef)
	{
		return null;
	}

	public LazyDefList(List<string> inDefIDs, Func<List<string>, List<T>> inGetFunc)
	{
	}
}
