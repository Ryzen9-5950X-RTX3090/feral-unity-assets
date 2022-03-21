using System;
using System.Runtime.InteropServices;
using LitJson;

public sealed class Item : ISoftReferable
{
	[NonSerialized]
	public DateTime timeCreated;

	public readonly string Id;

	public readonly ItemType ItemType;

	private string _defID;

	private BaseDef _def;

	private bool _dirty;

	private ComponentContainer _components;

	public string defID
	{
		get
		{
			return null;
		}
	}

	public BaseDef Def
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public bool IsDirty
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public T GetDef<T>() where T : BaseDef
	{
		return null;
	}

	public T GetDefComponent<T>() where T : DefComponent
	{
		return null;
	}

	public Item(JsonData data)
	{
	}

	public Item(ItemType category, [Optional] BaseDef def)
	{
	}

	private void LoadDef(string defId)
	{
	}

	public void OnLoaded()
	{
	}

	public void UpdateFromServer(Item clone)
	{
	}

	public JsonData ToJson()
	{
		return null;
	}

	public ItemComponent AddComponentFromUpdate(ItemComponent compFromServer)
	{
		return null;
	}

	public T AddComponent<T>(bool isClientOnly = false) where T : ItemComponent
	{
		return null;
	}

	public T AddComponent<T>(JsonData json) where T : ItemComponent
	{
		return null;
	}

	public ItemComponent AddComponent(Type ofType)
	{
		return null;
	}

	public ItemComponent GetComponent(Type ofType)
	{
		return null;
	}

	public T GetComponent<T>() where T : ItemComponent
	{
		return null;
	}

	public bool HasComponent<T>() where T : ItemComponent
	{
		return default(bool);
	}

	public void RemoveComponent<T>() where T : ItemComponent
	{
	}

	public void ForEachComponent<T>(Action<T> op) where T : ItemComponent
	{
	}

	public void ForEachComponent(Action<ItemComponent> op)
	{
	}

	public bool HasDefComponent<T>() where T : DefComponent
	{
		return default(bool);
	}
}
