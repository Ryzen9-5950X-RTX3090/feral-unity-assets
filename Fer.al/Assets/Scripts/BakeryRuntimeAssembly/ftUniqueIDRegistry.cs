using System.Collections.Generic;

public static class ftUniqueIDRegistry
{
	public static Dictionary<int, int> Mapping;

	public static Dictionary<int, int> MappingInv;

	public static void Deregister(int id)
	{
	}

	public static void Register(int id, int value)
	{
	}

	public static int GetInstanceId(int id)
	{
		return default(int);
	}

	public static int GetUID(int instanceId)
	{
		return default(int);
	}
}
