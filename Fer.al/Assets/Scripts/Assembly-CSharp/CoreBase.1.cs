using System;
using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using UnityEngine;

public abstract class CoreBase<T> : CoreBase where T : CoreBase<T>
{
	[NonSerialized]
	public string debugDateString;

	[NonSerialized]
	public double debugAddedSeconds;

	[NonSerialized]
	public string debugTimeString;

	private static bool _quitting;

	protected static T _instance;

	protected static bool _loaded;

	[NonSerialized]
	public string currentSplashProgressName;

	[NonSerialized]
	public int currentSplashProgressNumber;

	private static FieldInfo[] _managerFields;

	private static List<GameObject> _doNotDestroyOnLoadList;

	public static bool DebugVerbose
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public virtual bool DestroyOnLoad
	{
		get
		{
			return default(bool);
		}
	}

	public static bool IsResetting
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

	public static bool Quitting
	{
		get
		{
			return default(bool);
		}
	}

	public static T instance
	{
		get
		{
			return null;
		}
	}

	public static bool Loaded
	{
		get
		{
			return default(bool);
		}
	}

	private static FieldInfo[] ManagerFields
	{
		get
		{
			return null;
		}
	}

	private static string DebugVerboseName
	{
		get
		{
			return null;
		}
	}

	private FieldInfo GetManagerField(ManagerBase inManager)
	{
		return null;
	}

	[IteratorStateMachine(typeof(CoreBase<>.<GetManagerList>d__27))]
	public IEnumerable<ManagerBase> GetManagerList()
	{
		return null;
	}

	public void AddSceneManagerAndInit(ManagerBase inManager)
	{
	}

	public void RemoveSceneManagerAndDeinit(ManagerBase inManager)
	{
	}

	public static ManagerBase GetManagerInstance(ManagerBase inManager)
	{
		return null;
	}

	public static ManagerBase GetManagerInstance(Type inType)
	{
		return null;
	}

	private void Awake()
	{
	}

	protected virtual void MAwake()
	{
	}

	[IteratorStateMachine(typeof(CoreBase<>.<InitializeManagers>d__34))]
	private IEnumerator InitializeManagers()
	{
		return null;
	}

	protected virtual void OnManagersInitialized()
	{
	}

	public void OnApplicationQuit()
	{
	}

	public void DeinitManagers()
	{
	}

	private void OnDestroy()
	{
	}

	protected static void Log(string inLog)
	{
	}

	protected static void LogError(string inLog)
	{
	}

	public static void RegisterDoNotDestroyOnLoadObject(GameObject inObj)
	{
	}

	public static void UnregisterDoNotDestroyOnLoadObject(GameObject inObj)
	{
	}

	public static void DestroyDoNotDestroyOnLoadList()
	{
	}
}
