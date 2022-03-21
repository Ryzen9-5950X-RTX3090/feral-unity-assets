using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("â\u009c« Utility")]
	[Description("Wait For Reward popup to appear and be dismissed")]
	public class WaitForLevelUpReward : ActionTask
	{
		[StructLayout(LayoutKind.Auto)]
		[CompilerGenerated]
		private struct <DoWait>d__4 : IAsyncStateMachine
		{
			public int <>1__state;

			public AsyncVoidMethodBuilder <>t__builder;

			public WaitForLevelUpReward <>4__this;

			private TaskAwaiter<WindowOpenedMessage> <>u__1;

			private TaskAwaiter<WindowClosedMessage> <>u__2;

			private void MoveNext()
			{
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}
		}

		public float failTimeout;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnExecute()
		{
		}

		[AsyncStateMachine(typeof(<DoWait>d__4))]
		private void DoWait()
		{
		}
	}
}
