using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace UniRx.Async.CompilerServices
{
	internal class MoveNextRunner<TStateMachine> where TStateMachine : IAsyncStateMachine
	{
		public TStateMachine StateMachine;

		[DebuggerHidden]
		public void Run()
		{
		}
	}
}
