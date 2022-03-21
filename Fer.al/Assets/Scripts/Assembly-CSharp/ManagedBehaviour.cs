using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class ManagedBehaviour : MonoBehaviour
{
	private ManagedBehaviourManagerAttribute _managerAttribute;

	private string _managerName;

	private Dictionary<string, Transform> _fastFindChildByNameDict;

	private static Dictionary<string, string> _managerNameDict;

	private ManagerBase _manager;

	private Coroutine _registerWithManagerRoutine;

	public bool managedRegistered
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool managedAwoken
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool managedStarted
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool managedStartedAfterLocal
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool managedEnabled
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool managedDisabled
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	private ManagerBase Manager
	{
		get
		{
			return null;
		}
	}

	private void AddToFastFindChildByNameDict(Transform inTransform)
	{
	}

	public void ResetFastFindChildByName()
	{
	}

	public Transform FastFindChildByName(Transform inParent, string inFindName, bool InExcludeParent = false, bool inFuzzySearch = true, bool inShowMissingError = false)
	{
		return null;
	}

	private Transform PrivateSlowFindChildByName(Transform inParent, string inFindName)
	{
		return null;
	}

	public virtual void Awake()
	{
	}

	public virtual void UAwake()
	{
	}

	public void AwakeInternal()
	{
	}

	public virtual void MAwake()
	{
	}

	public virtual void OnEnable()
	{
	}

	public void OnEnableInternal()
	{
	}

	public virtual void MOnEnable()
	{
	}

	public virtual void Start()
	{
	}

	public void StartInternal()
	{
	}

	public virtual void MStart()
	{
	}

	public void StartAfterLocalInternal()
	{
	}

	public virtual void MStartAfterLocal()
	{
	}

	public virtual void OnDisable()
	{
	}

	public void OnDisableInternal()
	{
	}

	public virtual void MOnDisable()
	{
	}

	public virtual void OnDestroy()
	{
	}

	public virtual void MOnDestroy()
	{
	}

	public virtual void UpdateInternal()
	{
	}

	public virtual void MUpdate()
	{
	}

	[IteratorStateMachine(typeof(<RegisterWithManager>d__55))]
	private IEnumerator RegisterWithManager()
	{
		return null;
	}

	private void UnregisterWithManager()
	{
	}

	public virtual void SetInstanceInternal()
	{
	}

	public virtual void UnsetInstanceInternal()
	{
	}
}
