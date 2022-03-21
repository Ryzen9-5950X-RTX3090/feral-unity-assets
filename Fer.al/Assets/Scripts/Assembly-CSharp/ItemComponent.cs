using System;
using System.Runtime.CompilerServices;
using LitJson;

[Serializable]
public abstract class ItemComponent : ComponentBase, ISoftReferable
{
	public Item item
	{
		[CompilerGenerated]
		get
		{
			return null;
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsClientOnly
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public bool IsDirty
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		set
		{
		}
	}

	public virtual void OnAdded(Item item)
	{
	}

	public void ParseJson(Item item, JsonData jsonData)
	{
	}

	public virtual ItemComponent ParseJsonOverride(JsonData jsonData)
	{
		return null;
	}

	public JsonData ToJson()
	{
		return null;
	}

	protected virtual JsonData ToJsonOverride()
	{
		return null;
	}

	public void CopyInto(ItemComponent overwriteMe)
	{
	}

	public virtual void OnLoaded()
	{
	}

	public void UpdateFromServer(ItemComponent fromServer)
	{
	}

	protected virtual ItemComponent UpdateFromServerOverride(ItemComponent fromServer)
	{
		return null;
	}

	public virtual void OnAddedFromUpdate(ItemComponent fromUpdate)
	{
	}

	public virtual void OnRemovedFromUpdate()
	{
	}

	protected virtual void OnCopiedFrom(ItemComponent from)
	{
	}

	public static Type GetTypeFromJsonKey(string key)
	{
		return null;
	}

	public static string GetJsonKeyFromType(Type type)
	{
		return null;
	}
}
