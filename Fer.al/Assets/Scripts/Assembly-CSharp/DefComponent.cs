using System;
using System.Runtime.CompilerServices;

public abstract class DefComponent : ComponentBase
{
	public BaseDef def
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

	public string defID
	{
		get
		{
			return null;
		}
	}

	public string defName
	{
		get
		{
			return null;
		}
	}

	public void LoadEntry(BaseDef inDef)
	{
	}

	protected virtual void LoadEntry()
	{
	}

	public virtual void OnLoaded()
	{
	}

	public T GetComponent<T>() where T : DefComponent
	{
		return null;
	}

	public T AddComponent<T>() where T : DefComponent
	{
		return null;
	}

	public void RemoveComponent<T>() where T : DefComponent
	{
	}

	public void ForeachComponent<T>(Action<T> action) where T : class
	{
	}
}
