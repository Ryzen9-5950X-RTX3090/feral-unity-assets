using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;
using UnityEngine;

public class QRoutineGroup
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <StartQRoutineAsync>d__76 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<QRoutine> <>t__builder;

		public QRoutineGroup <>4__this;

		public IEnumerator inRoutine;

		public Action<QRoutine> inFinishedAction;

		public Action<QRoutine> inCanceledAction;

		private QRoutine <qRoutine>5__2;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <StartQRoutineAsync>d__77<T> : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<T> <>t__builder;

		public QRoutineGroup <>4__this;

		public IEnumerator inRoutine;

		public Action<QRoutine> inFinishedAction;

		public Action<QRoutine> inCanceledAction;

		private QRoutine<T> <qRoutine>5__2;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	public QRoutineGroup parentGroup;

	private string _name;

	private string _fullPathName;

	private List<QRoutine> _routineQueue;

	public List<QRoutineGroup> _subGroups;

	private List<UnityEngine.Object> _trackedAssets;

	private bool _canBeCanceled;

	private bool _canTrackAssets;

	private bool _hasTargetObject;

	private GameObject _targetObject;

	private string _targetName;

	private bool _removed;

	private int _creationTime;

	private int _emptyTimeout;

	private int _priority;

	private int _maxRoutinesPerFrame;

	public QRoutineGroup RootParentGroup
	{
		get
		{
			return null;
		}
	}

	public string Name
	{
		get
		{
			return null;
		}
	}

	public string FullPathName
	{
		get
		{
			return null;
		}
	}

	public List<QRoutine> RoutineQueue
	{
		get
		{
			return null;
		}
	}

	public List<QRoutineGroup> SubGroups
	{
		get
		{
			return null;
		}
	}

	public List<UnityEngine.Object> TrackedAssets
	{
		get
		{
			return null;
		}
	}

	public bool CanBeCanceledBeforeFinish
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool CanTrackAssets
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool HasTargetObject
	{
		get
		{
			return default(bool);
		}
	}

	public GameObject TargetObject
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string TargetName
	{
		get
		{
			return null;
		}
	}

	public bool TargetObjectDestroyed
	{
		get
		{
			return default(bool);
		}
	}

	public bool Removed
	{
		get
		{
			return default(bool);
		}
		set
		{
		}
	}

	public bool HasRoutines
	{
		get
		{
			return default(bool);
		}
	}

	public bool EmptyTimeoutHit
	{
		get
		{
			return default(bool);
		}
	}

	public int Priority
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int MaxRoutinesPerFrame
	{
		get
		{
			return default(int);
		}
	}

	public int CurrentRunningRoutineCount
	{
		get
		{
			return default(int);
		}
	}

	public QRoutineGroup(string inName, [Optional] GameObject inTargetObject, int inMaxRoutinesPerFrame = -1, int inEmptyTimeout = -1)
	{
	}

	public void TrackAsset(UnityEngine.Object inAsset)
	{
	}

	public void SortSubGroupsByPriority()
	{
	}

	private void AddRoutineToQueue(QRoutine inQRoutine, QRoutineAddPriority inPriority)
	{
	}

	public void Update()
	{
	}

	public void CancelAllRoutines()
	{
	}

	public void DestroyTrackedAssets()
	{
	}

	public void GetGroupRunningRoutineCount(ref int inRefCurrentRunningRoutineCount)
	{
	}

	public void UpdateTimedoutSubGroups()
	{
	}

	public void UpdateRunningRoutines()
	{
	}

	public void StartQueuedRoutines(ref int inRefCurrentRunningRoutineCount, int inMaxRoutinesPerFrame)
	{
	}

	public void PruneNullAndFinishedRoutines()
	{
	}

	public void AddSubGroup(QRoutineGroup inGroup)
	{
	}

	public QRoutineGroup GetAutomaticSubGroupWithTarget(GameObject inTargetObject)
	{
		return null;
	}

	public QRoutineGroup GetSubGroupWithTarget(GameObject inTargetObject)
	{
		return null;
	}

	public bool InsertSubGroupAtIndex(QRoutineGroup inGroup, int inIndex)
	{
		return default(bool);
	}

	public bool AddSubGroupBefore(QRoutineGroup inGroup, QRoutineGroup inOtherGroup)
	{
		return default(bool);
	}

	public bool AddSubGroupAfter(QRoutineGroup inGroup, QRoutineGroup inOtherGroup)
	{
		return default(bool);
	}

	public bool RemoveSubGroup(QRoutineGroup inGroup)
	{
		return default(bool);
	}

	[AsyncStateMachine(typeof(<StartQRoutineAsync>d__76))]
	public Task<QRoutine> StartQRoutineAsync(IEnumerator inRoutine, [Optional] Action<QRoutine> inFinishedAction, [Optional] Action<QRoutine> inCanceledAction)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<StartQRoutineAsync>d__77<>))]
	public Task<T> StartQRoutineAsync<T>(IEnumerator inRoutine, [Optional] Action<QRoutine> inFinishedAction, [Optional] Action<QRoutine> inCanceledAction)
	{
		return null;
	}

	public IEnumerator StartQActionAndWait(Action<QRoutine> inAction, [Optional] Action<QRoutine> inFinishedAction, [Optional] Action<QRoutine> inCanceledAction)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<StartQRoutineAndWait>d__79))]
	public IEnumerator StartQRoutineAndWait(IEnumerator inRoutine, [Optional] Action<QRoutine> inFinishedAction, [Optional] Action<QRoutine> inCanceledAction)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<StartQRoutineAndWait>d__80))]
	public IEnumerator StartQRoutineAndWait(StartQRoutineOptions inOptions)
	{
		return null;
	}

	public QRoutine StartQAction(Action<QRoutine> inAction, [Optional] Action<QRoutine> inFinishedAction, [Optional] Action<QRoutine> inCanceledAction)
	{
		return null;
	}

	public QRoutine StartQRoutine(IEnumerator inRoutine, [Optional] Action<QRoutine> inFinishedAction, [Optional] Action<QRoutine> inCanceledAction)
	{
		return null;
	}

	public QRoutine<T> StartQRoutine<T>(IEnumerator inRoutine, [Optional] Action<QRoutine> inFinishedAction, [Optional] Action<QRoutine> inCanceledAction)
	{
		return null;
	}

	public QRoutine StartQRoutine(StartQRoutineOptions inOptions)
	{
		return null;
	}

	public QRoutine<T> StartQRoutine<T>(StartQRoutineOptions inOptions)
	{
		return null;
	}
}
