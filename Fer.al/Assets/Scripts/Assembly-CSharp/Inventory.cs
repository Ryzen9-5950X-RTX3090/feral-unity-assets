using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using LitJson;
using WW.Debug;

[Serializable]
public class Inventory
{
	private Dictionary<string, Item> _itemsById;

	private Dictionary<ItemType, HashSet<Item>> _itemsByType;

	private Dictionary<Type, HashSet<ItemComponent>> _itemsByComponent;

	private Dictionary<string, HashSet<Item>> _itemsByDefId;

	private Dictionary<ItemType, int> _itemCountByType;

	private Dictionary<ItemType, int> _maxItemsByType;

	public ICollection<Item> All
	{
		get
		{
			return null;
		}
	}

	public Inventory()
	{
	}

	public Inventory(JsonData jsonData)
	{
	}

	public JsonData ToJson()
	{
		return null;
	}

	public void ParseItemMaxes(JsonData jsonData)
	{
	}

	public void SetItemMax(ItemType itemType, int max)
	{
	}

	private int DecrementItemCount(ItemType type, int amount = 1)
	{
		return default(int);
	}

	private int IncrementItemCount(ItemType type, int amount = 1)
	{
		return default(int);
	}

	public Item AddFromServer(Item item)
	{
		return null;
	}

	public Item AddClientOnlyItem(ItemType category, [Optional] BaseDef def)
	{
		return null;
	}

	private HashSet<Item> GetItemsByTypeSet(ItemType type)
	{
		return null;
	}

	private HashSet<ItemComponent> GetItemsByComponentSet(Type type)
	{
		return null;
	}

	private HashSet<Item> GetItemsByDefIdSet(string defId)
	{
		return null;
	}

	public Item Remove(string id)
	{
		return null;
	}

	public void CompleteQuest(QuestItemComponent inQuest, QuestSummary inSummary)
	{
	}

	public void CompleteQuest(string inQuestDefId, QuestSummary inSummary)
	{
	}

	public void ReopenQuest(string inQuestDefId)
	{
	}

	public void ReopenQuest(QuestItemComponent inQuest)
	{
	}

	public void AddTestQuest(string inQuestId)
	{
	}

	public void CompleteTestQuest()
	{
	}

	public void AddAllSanctuaryItemsToInventory()
	{
	}

	public int GetItemCount(ItemType type)
	{
		return default(int);
	}

	public int GetItemCount(string inDefId)
	{
		return default(int);
	}

	public int GetMaxItems(ItemType type)
	{
		return default(int);
	}

	public bool Contains(string id)
	{
		return default(bool);
	}

	public Item GetById(string id)
	{
		return null;
	}

	public ICollection<ItemComponent> GetAllWithComponent<T>() where T : ItemComponent
	{
		return null;
	}

	public ICollection<Item> GetAllWithComponents(Type[] components)
	{
		return null;
	}

	public IEnumerable<T> GetAllWithComponentAs<T>() where T : ItemComponent
	{
		return null;
	}

	public ICollection<Item> GetAllOfType(ItemType type)
	{
		return null;
	}

	public Item GetItemByDefId(string defId)
	{
		return null;
	}

	public Item GetItemById(string id)
	{
		return null;
	}

	public ICollection<Item> GetItemsByDefId(string defId)
	{
		return null;
	}

	[DebugButton("PrintAllLooks", "Inventory", true, false)]
	public static void PrintAllLookItems()
	{
	}
}
