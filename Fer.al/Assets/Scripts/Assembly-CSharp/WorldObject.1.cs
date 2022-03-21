using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class WorldObject<T> : WorldObject where T : WorldObjectInfo
{
	private T _info;

	private string _worldObjectDefID;

	private Queue<ValueTuple<T, Action<GameObject, T>>> _newInfos;

	private T _currentSettingInfo;

	public T Info
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public string WorldObjectDefID
	{
		get
		{
			return null;
		}
		private set
		{
		}
	}

	public virtual QRoutineGroup BuildQRoutineGroup
	{
		get
		{
			return null;
		}
	}

	public static WorldObject<T> Instantiate(string inWorldObjectInstanceID, string inWorldObjectDefID, Vector3 inPosition, Quaternion inRotation)
	{
		return null;
	}

	public virtual void OnCreate(T inInfo, Action<GameObject, T> inFinishedCallback)
	{
	}

	public QRoutine SetNewInfo(T inInfo, Action<GameObject, T> inFinishedCallback)
	{
		return null;
	}

	[IteratorStateMachine(typeof(WorldObject<>.<SetNewInfoRoutine>d__13))]
	private IEnumerator SetNewInfoRoutine()
	{
		return null;
	}

	[IteratorStateMachine(typeof(WorldObject<>.<Build>d__16))]
	public virtual IEnumerator Build()
	{
		return null;
	}

	public override void MOnDestroy()
	{
	}
}
