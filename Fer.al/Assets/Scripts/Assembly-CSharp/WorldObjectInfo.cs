using System;
using System.Collections.Generic;

public class WorldObjectInfo : BaseInfo
{
	[NonSerialized]
	private List<WorldObject> _registeredWorldObjects;

	public List<WorldObject> RegisteredWorldObjects
	{
		get
		{
			return null;
		}
	}

	public void RegisterWorldObject(WorldObject inWorldObject)
	{
	}

	public void UnregisterWorldObject(WorldObject inWorldObject)
	{
	}
}
