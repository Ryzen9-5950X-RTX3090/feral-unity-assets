using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CoreReset : MonoBehaviour
{
	public static CoreReset instance
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

	protected virtual string _name
	{
		get
		{
			return null;
		}
	}

	private void Awake()
	{
	}

	[IteratorStateMachine(typeof(<ResetCoroutine>d__7))]
	protected virtual IEnumerator ResetCoroutine()
	{
		return null;
	}

	protected void Delete(Object[] inObjects)
	{
	}

	protected List<T> GetDeleteList<T>(T[] inList) where T : class
	{
		return null;
	}

	protected void DeleteMaterial(Material inMaterial)
	{
	}

	protected void HandleCoreResetTargets()
	{
	}
}
