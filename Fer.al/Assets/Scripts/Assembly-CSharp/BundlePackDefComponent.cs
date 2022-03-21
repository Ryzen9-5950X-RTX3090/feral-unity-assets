using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using UnityEngine;

[ChartComponent("BundlePack")]
public class BundlePackDefComponent : DefComponent
{
	[Serializable]
	public class CraftableItemsEntry
	{
		[ChartDef("CraftableItem", new string[] { })]
		public string itemDefID;

		[ChartInt]
		public int count;
	}

	[SerializeField]
	[JsonProperty]
	[ChartList]
	private List<CraftableItemsEntry> _craftableItems;

	public List<CraftableItemsEntry> CraftableItems
	{
		get
		{
			return null;
		}
	}

	public CraftableItemsEntry GetOnlyItem()
	{
		return null;
	}

	public List<Item> GenerateItemList()
	{
		return null;
	}

	protected override void LoadEntry()
	{
	}
}
