using SQLite4Unity3d;

public static class BundleDbUtils
{
	private static SQLiteConnection _sqLiteConnection;

	public static string BundleDbPath
	{
		get
		{
			return null;
		}
	}

	public static void LoadBundleDbIfNull()
	{
	}

	public static void CloseBundleDbConnection()
	{
	}

	public static void DeleteBundleDb()
	{
	}

	public static void InsertBundleDbEntry(string bundleName, string unityHash)
	{
	}

	public static BundleDBEntry GetBundleEntry(string bundleName)
	{
		return null;
	}

	public static string GetFullBundleName(string inBundlePath)
	{
		return null;
	}
}
