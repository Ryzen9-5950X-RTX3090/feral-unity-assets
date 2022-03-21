using System;
using UnityEngine;

[Serializable]
public class ChartDef
{
	[SerializeField]
	private string _defID;

	[NonSerialized]
	private BaseDef _def;

	public string DefID
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public BaseDef Def
	{
		get
		{
			return null;
		}
	}

	public static implicit operator BaseDef(ChartDef inDef)
	{
		return null;
	}

	public static implicit operator string(ChartDef inDef)
	{
		return null;
	}
}
