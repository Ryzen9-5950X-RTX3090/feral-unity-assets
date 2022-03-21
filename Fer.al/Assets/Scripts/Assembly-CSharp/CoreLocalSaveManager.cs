using System.Runtime.CompilerServices;
using CodeStage.AntiCheat.ObscuredTypes;

public class CoreLocalSaveManager
{
	private static CoreLocalSaveManager _instance;

	public static CoreLocalSaveManager instance
	{
		get
		{
			return null;
		}
	}

	public string deviceID
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

	public void SaveNonPrefs(string inFilename, int inValue)
	{
	}

	public void SaveNonPrefs(string inFilename, string inValue)
	{
	}

	public int LoadNonPrefsInt(string inFilename)
	{
		return default(int);
	}

	public string LoadNonPrefsString(string inFilename)
	{
		return null;
	}

	public void DeleteNonPrefs(string inFilename)
	{
	}

	private void SavesAlterationDetected()
	{
	}

	public void DeleteAll()
	{
	}

	public bool HasKey(string inKey, bool inUseUserID)
	{
		return default(bool);
	}

	public void DeleteKey(string inKey, bool inUseUserID)
	{
	}

	public void SetInt(string inKey, ObscuredInt inValue, bool inUseUserID, bool inSaveNow = true)
	{
	}

	public ObscuredInt GetInt(string inKey, bool inUseUserID)
	{
		return default(ObscuredInt);
	}

	public ObscuredInt GetInt(string inKey, ObscuredInt inDefault, bool inUseUserID)
	{
		return default(ObscuredInt);
	}

	public void SetFloat(string inKey, ObscuredFloat inValue, bool inUseUserID, bool inSaveNow = true)
	{
	}

	public ObscuredFloat GetFloat(string inKey, bool inUseUserID)
	{
		return default(ObscuredFloat);
	}

	public ObscuredFloat GetFloat(string inKey, ObscuredFloat inDefault, bool inUseUserID)
	{
		return default(ObscuredFloat);
	}

	public void SetBool(string inKey, ObscuredBool inValue, bool inUseUserID, bool inSaveNow = true)
	{
	}

	public ObscuredBool GetBool(string inKey, bool inUseUserID)
	{
		return default(ObscuredBool);
	}

	public ObscuredBool GetBool(string inKey, ObscuredBool inDefault, bool inUseUserID)
	{
		return default(ObscuredBool);
	}

	public void SetString(string inKey, ObscuredString inValue, bool inUseUserID, bool inSaveNow = true)
	{
	}

	public ObscuredString GetString(string inKey, bool inUseUserID)
	{
		return null;
	}

	public ObscuredString GetString(string inKey, ObscuredString inDefault, bool inUseUserID)
	{
		return null;
	}

	public void SetVector3(string inKey, ObscuredVector3 inValue, bool inUseUserID, bool inSaveNow = true)
	{
	}

	public ObscuredVector3 GetVector3(string inKey, bool inUseUserID)
	{
		return default(ObscuredVector3);
	}

	public ObscuredVector3 GetVector3(string inKey, ObscuredVector3 inDefault, bool inUseUserID)
	{
		return default(ObscuredVector3);
	}

	protected virtual string GetKey(string inKey, bool inUseUserID)
	{
		return null;
	}

	public void Save(bool inSaveNow = true)
	{
	}
}
