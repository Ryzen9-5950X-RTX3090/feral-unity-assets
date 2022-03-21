using System;
using DG.DeInspektor.Attributes;
using UnityEngine;

[Serializable]
public struct HexCoord
{
	[SerializeField]
	[DeDisabled("hiddenForDisabled", false)]
	private int _q;

	[SerializeField]
	private int _r;

	public int q
	{
		get
		{
			return default(int);
		}
	}

	public int r
	{
		get
		{
			return default(int);
		}
	}

	public int s
	{
		get
		{
			return default(int);
		}
	}

	public HexCoord(int q, int r)
	{
	}

	public static HexCoord operator +(HexCoord a, HexCoord b)
	{
		return default(HexCoord);
	}

	public static HexCoord operator -(HexCoord a, HexCoord b)
	{
		return default(HexCoord);
	}
}
