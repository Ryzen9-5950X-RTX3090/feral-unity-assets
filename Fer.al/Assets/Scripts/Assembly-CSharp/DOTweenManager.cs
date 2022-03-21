using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

public class DOTweenManager : SingletonManagerBase<DOTweenManager>
{
	[StructLayout(LayoutKind.Auto)]
	[CompilerGenerated]
	private struct <RuntimeInitializeOnLoad>d__6 : IAsyncStateMachine
	{
		public int <>1__state;

		public AsyncVoidMethodBuilder <>t__builder;

		private TaskAwaiter <>u__1;

		private void MoveNext()
		{
		}

		[DebuggerHidden]
		private void SetStateMachine(IAsyncStateMachine stateMachine)
		{
		}
	}

	[SerializeField]
	[Range(1f, 1000f)]
	private int _tweenersCapacity;

	[SerializeField]
	[Range(1f, 1000f)]
	private int _sequencesCapacity;

	public int TweenersCapacity
	{
		get
		{
			return default(int);
		}
	}

	public int SequencesCapacity
	{
		get
		{
			return default(int);
		}
	}

	[RuntimeInitializeOnLoadMethod]
	[AsyncStateMachine(typeof(<RuntimeInitializeOnLoad>d__6))]
	private static void RuntimeInitializeOnLoad()
	{
	}

	public void SetTweensCapacity(int tweenersCapacity, int sequencesCapacity)
	{
	}
}
