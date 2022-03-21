using System;
using System.Collections.Generic;
using CodeStage.AntiCheat.ObscuredTypes;
using UnityEngine;

[Serializable]
public class CachedUserVar
{
	[SerializeField]
	[RootSelector("User Var Def Id", "CraftableItemChartData", false, false)]
	private string userVarDefId;

	private Dictionary<int, ObscuredLong> _values;

	private List<UserVarSetOperation> _pendingSetOperations;

	public long Value
	{
		get
		{
			return default(long);
		}
		set
		{
		}
	}

	public long this[int key]
	{
		get
		{
			return default(long);
		}
		set
		{
		}
	}

	public CachedUserVar()
	{
	}

	public CachedUserVar(string userVarDefId)
	{
	}

	public long GetValue(int inKey)
	{
		return default(long);
	}

	public void SetValue(int inKey, long inValue, int inValue2 = 0)
	{
	}

	public void SetValueLazy(int inKey, long inValue, int inValue2 = 0)
	{
	}

	public void ApplyPendingSetOperations()
	{
	}

	public void RefreshCache()
	{
	}

	public long GetDefaultValue()
	{
		return default(long);
	}

	public void ClearUserVarDebug()
	{
	}
}
