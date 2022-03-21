public static class PersistentDataPathUtil
{
	private static string[] _persistentDataPaths;

	public static string PersistentDataPathInternal
	{
		get
		{
			return null;
		}
	}

	public static string PersistentDataPathExternal
	{
		get
		{
			return null;
		}
	}

	public static string[] PersistentDataPaths
	{
		get
		{
			return null;
		}
	}

	public static string PersistentDataPath
	{
		get
		{
			return null;
		}
	}

	public static bool IsDirectoryWritable(string path)
	{
		return default(bool);
	}

	private static string GetPersistentDataPath(string[] components)
	{
		return null;
	}

	public static string GetPersistentFile(string relativePath)
	{
		return null;
	}

	public static bool SaveData(string relativePath, byte[] data)
	{
		return default(bool);
	}

	private static bool SaveData(string relativePath, byte[] data, int pathIndex)
	{
		return default(bool);
	}

	public static bool FileExists(string path, string relativePath)
	{
		return default(bool);
	}
}
