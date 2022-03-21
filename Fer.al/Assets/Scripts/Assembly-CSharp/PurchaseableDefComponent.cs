using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

[ChartComponent("Purchaseable")]
public class PurchaseableDefComponent : DefComponent
{
	[Serializable]
	public class CostEntry
	{
		[ChartDef("CraftableItem", new string[] { })]
		public string itemDefID;

		[ChartInt]
		public int count;

		public int RecycleCount
		{
			get
			{
				return default(int);
			}
		}
	}

	[Serializable]
	public class YieldEntry
	{
		[ChartDef("CraftableItem", new string[] { })]
		public string itemDefID;

		[ChartInt]
		public int count;
	}

	[SerializeField]
	[JsonProperty]
	[ChartList]
	private List<CostEntry> _cost;

	[SerializeField]
	[ChartBool]
	private bool _defaultYield;

	[SerializeField]
	[ChartList]
	private List<YieldEntry> _yields;

	private List<YieldEntry> _defaultYields;

	public List<CostEntry> Cost
	{
		get
		{
			return null;
		}
	}

	public List<YieldEntry> Yields
	{
		get
		{
			return null;
		}
	}

	public bool UserHasCraftingRequirements()
	{
		return default(bool);
	}

	protected override void LoadEntry()
	{
	}
}
