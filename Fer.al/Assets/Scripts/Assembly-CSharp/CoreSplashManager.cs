using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CoreSplashManager : CoreManagerBase<CoreSplashManager>
{
	private static List<GameObject> _doNotDestroyOnLoadList;

	protected string _currentVersion;

	public string currentVersion
	{
		get
		{
			return null;
		}
	}

	protected string CurrentStoreVersion
	{
		get
		{
			return null;
		}
	}

	protected string PreviousStoreVersion
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public bool internetConnected
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		protected set
		{
		}
	}

	public bool IsSupported
	{
		get
		{
			return default(bool);
		}
	}

	public override bool HasInitCoroutine()
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<InitCoroutine>d__14))]
	public override IEnumerator InitCoroutine()
	{
		return null;
	}

	public override void MOnDestroy()
	{
	}

	public static void RegisterDoNotDestroyOnLoadObject(GameObject inObj)
	{
	}

	public static void UnregisterDoNotDestroyOnLoadObject(GameObject inObj)
	{
	}

	[IteratorStateMachine(typeof(<DestroySceneObjects>d__20))]
	protected IEnumerator DestroySceneObjects()
	{
		return null;
	}
}
