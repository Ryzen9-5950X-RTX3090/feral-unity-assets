using System;

public class LazyDef<T> where T : BaseDef
{
	private Func<string, T> _getFunc;

	private string _defID;

	private T _def;

	public string DefID
	{
		get
		{
			return null;
		}
	}

	public T Def
	{
		get
		{
			return null;
		}
	}

	public static implicit operator T(LazyDef<T> inDef)
	{
		return null;
	}

	public static implicit operator string(LazyDef<T> inDef)
	{
		return null;
	}

	public LazyDef(string inDefID, Func<string, T> inGetFunc)
	{
	}

	public LazyDef(string inDefID, Type inChartType)
	{
	}
}
