using System;
using System.Runtime.CompilerServices;
using UnityEngine;

[Serializable]
public abstract class PurchasableDef : LocalizedNameBundledDef
{
	public string saleCalendarRef;

	public bool isRare;

	private CurrencyType _currencyType;

	protected int _recycleValue;

	protected long _dateAdd;

	protected long _dateRemove;

	[Header("UI")]
	public float uiScale;

	public Vector3 uiRotation;

	public Vector3 uiPosition;

	public bool cantTrade;

	public bool cantRecycle;

	[Header("OS")]
	public SpecificOS specificOS;

	public CurrencyType CurrencyType
	{
		get
		{
			return default(CurrencyType);
		}
	}

	public int RecycleValue
	{
		get
		{
			return default(int);
		}
	}

	public long DateAdd
	{
		get
		{
			return default(long);
		}
	}

	public long DateRemove
	{
		get
		{
			return default(long);
		}
	}

	public bool IsPremium
	{
		get
		{
			return default(bool);
		}
	}

	public bool IsTicket
	{
		get
		{
			return default(bool);
		}
	}

	public virtual bool canTrade
	{
		get
		{
			return default(bool);
		}
	}

	public virtual bool canRecycle
	{
		get
		{
			return default(bool);
		}
	}

	public bool storePackStatusRequired
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int storeXPLevelRequirement
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public int rarity
	{
		[CompilerGenerated]
		get
		{
			return default(int);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public override void LoadEntry()
	{
	}
}
