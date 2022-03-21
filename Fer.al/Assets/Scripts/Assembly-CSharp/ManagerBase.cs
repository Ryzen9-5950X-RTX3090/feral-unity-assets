using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;

public class ManagerBase : MonoBehaviour
{
	public bool debugAlwaysVerboseOnDevice;

	[NonSerialized]
	private bool _inited;

	[NonSerialized]
	public bool initedByCore;

	[NonSerialized]
	public bool sceneManager;

	private List<ManagedBehaviour> _registeredBehaviours;

	private List<ManagedBehaviour> _registeredDisableBehaviours;

	private List<string> _registeredBehaviourNames;

	private int _registeredBehavioursCount;

	private int _registeredDisableBehavioursCount;

	private Type _cachedType;

	private static Dictionary<string, ManagerBase> _instanceDictionary;

	[NonSerialized]
	public string currentSplashProgressName;

	private string _debugVerboseName;

	private bool _verbose;

	public bool DebugVerbose
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool Inited
	{
		get
		{
			return default(bool);
		}
	}

	public bool loaded
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

	public List<ManagedBehaviour> registeredBehaviours
	{
		get
		{
			return null;
		}
	}

	public List<ManagedBehaviour> registeredDisableBehaviours
	{
		get
		{
			return null;
		}
	}

	public string DebugVerboseName
	{
		get
		{
			return null;
		}
	}

	public Type GetTypeCached()
	{
		return null;
	}

	public void RegisterManagedBehaviour(ManagedBehaviour inManagedBehaviour)
	{
	}

	public void UnregisterManagedBehaviour(ManagedBehaviour inManagedBehaviour)
	{
	}

	private void OnEnable()
	{
	}

	private void OnDestroy()
	{
	}

	public virtual void MOnDestroy()
	{
	}

	[IteratorStateMachine(typeof(<WaitForCoreAndInit>d__29))]
	private IEnumerator WaitForCoreAndInit()
	{
		return null;
	}

	public static ManagerBase GetInstanceForManagerName(string inName)
	{
		return null;
	}

	public void AddInstanceToDictInternal()
	{
	}

	public void InitInternal()
	{
	}

	public void SetInstance()
	{
	}

	public void UnsetInstance()
	{
	}

	public virtual void SetInstanceInternal()
	{
	}

	public virtual void UnsetInstanceInternal()
	{
	}

	public virtual void Init()
	{
	}

	public virtual bool HasInitCoroutine()
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<InitCoroutine>d__40))]
	public virtual IEnumerator InitCoroutine()
	{
		return null;
	}

	public virtual bool HasFinishCoroutine()
	{
		return default(bool);
	}

	[IteratorStateMachine(typeof(<FinishCoroutine>d__42))]
	public virtual IEnumerator FinishCoroutine()
	{
		return null;
	}

	public virtual int SplashProgressBarTotal()
	{
		return default(int);
	}

	private void Start()
	{
	}

	[IteratorStateMachine(typeof(<WaitForLoadedAndStart>d__46))]
	private IEnumerator WaitForLoadedAndStart()
	{
		return null;
	}

	public virtual void MStart()
	{
	}

	private void Update()
	{
	}

	private void ValidateRegisteredBehaviours()
	{
	}

	public void UpdateInternal()
	{
	}

	public virtual void MUpdate()
	{
	}

	public void DeinitInternal()
	{
	}

	public virtual void Deinit()
	{
	}

	[IteratorStateMachine(typeof(<RefreshDebugVerbose>d__58))]
	private IEnumerator RefreshDebugVerbose()
	{
		return null;
	}

	[Conditional("DEBUG")]
	[Conditional("UNITY_EDITOR")]
	public void Log(string inLog)
	{
	}

	[Conditional("DEBUG")]
	[Conditional("UNITY_EDITOR")]
	public void LogWarning(string inLog)
	{
	}

	public void LogError(string inLog)
	{
	}
}
