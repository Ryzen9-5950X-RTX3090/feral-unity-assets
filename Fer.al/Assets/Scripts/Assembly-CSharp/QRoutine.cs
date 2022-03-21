using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

public class QRoutine
{
	public class QRoutineResult<T>
	{
		public T result;

		public QRoutineResult(T inValue)
		{
		}
	}

	public class QRoutineWaitForSeconds
	{
		public float seconds;

		public float startTime;

		public bool OverTime
		{
			get
			{
				return default(bool);
			}
		}

		public QRoutineWaitForSeconds(float inSeconds)
		{
		}
	}

	public class QRoutineNoYield
	{
	}

	public class QRoutineWaitForFrames
	{
		public int frames;

		public int startFrame;

		public bool OverTime
		{
			get
			{
				return default(bool);
			}
		}

		public QRoutineWaitForFrames(int inFrames)
		{
		}
	}

	public class QRoutineWaitForTrue
	{
		public Func<bool> func;

		public bool True
		{
			get
			{
				return default(bool);
			}
		}

		public QRoutineWaitForTrue(Func<bool> inFunc)
		{
		}
	}

	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <StartQRoutineAsync>d__1 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<QRoutine> <>t__builder;

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
	private struct <StartQRoutineAsync>d__3<T> : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncTaskMethodBuilder<T> <>t__builder;

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

	private string _name;

	public string debugInitialStackTrace;

	public List<string> debugYieldedMethods;

	public QRoutineGroup parentGroup;

	public QRoutineState state;

	public bool noYield;

	public QRoutineAddPriority addPriority;

	public Action<QRoutine> startAction;

	public Action<QRoutine> finishedAction;

	public Action<QRoutine> canceledAction;

	public IEnumerator routine;

	private List<IEnumerator> _innerEnumeratorStack;

	public string Name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string FullChain
	{
		get
		{
			return null;
		}
	}

	public string FullChainWithInitialStackTrace
	{
		get
		{
			return null;
		}
	}

	public string InnerRoutineName
	{
		get
		{
			return null;
		}
	}

	public string RoutineName
	{
		get
		{
			return null;
		}
	}

	public bool Canceled
	{
		get
		{
			return default(bool);
		}
	}

	public bool Finished
	{
		get
		{
			return default(bool);
		}
	}

	public bool Running
	{
		get
		{
			return default(bool);
		}
	}

	public static QRoutine StartQRoutine(IEnumerator inRoutine, [Optional] Action<QRoutine> inFinishedAction, [Optional] Action<QRoutine> inCanceledAction)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<StartQRoutineAsync>d__1))]
	public static Task<QRoutine> StartQRoutineAsync(IEnumerator inRoutine, [Optional] Action<QRoutine> inFinishedAction, [Optional] Action<QRoutine> inCanceledAction)
	{
		return null;
	}

	public static QRoutine<T> StartQRoutine<T>(IEnumerator inRoutine, [Optional] Action<QRoutine> inFinishedAction, [Optional] Action<QRoutine> inCanceledAction)
	{
		return null;
	}

	[AsyncStateMachine(typeof(<StartQRoutineAsync>d__3<>))]
	public static Task<T> StartQRoutineAsync<T>(IEnumerator inRoutine, [Optional] Action<QRoutine> inFinishedAction, [Optional] Action<QRoutine> inCanceledAction)
	{
		return null;
	}

	public static QRoutineNoYield NoYield()
	{
		return null;
	}

	public static QRoutineResult<T> Result<T>(T inValue)
	{
		return null;
	}

	public static QRoutineWaitForSeconds WaitForSeconds(float inSeconds)
	{
		return null;
	}

	public static QRoutineWaitForFrames WaitForFrames(int inFrames)
	{
		return null;
	}

	public static QRoutineWaitForTrue WaitForTrue(Func<bool> inFunc)
	{
		return null;
	}

	public static List<object> GetMethodParameterValues(Delegate method)
	{
		return null;
	}

	public static string PrettyRoutineName(string inRoutineName)
	{
		return null;
	}

	public void Start()
	{
	}

	public void Update()
	{
	}

	public void Cancel()
	{
	}

	protected virtual bool IsResultYield(object inCurrent)
	{
		return default(bool);
	}

	protected virtual void OnResultYield(object inCurrent)
	{
	}

	public void Finish()
	{
	}

	[IteratorStateMachine(typeof(<Wait>d__51))]
	public IEnumerator Wait()
	{
		return null;
	}
}
