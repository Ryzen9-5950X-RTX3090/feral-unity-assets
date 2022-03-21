using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Name("Control Graph Owner", 0)]
	[Category("â\u009c« Utility")]
	[Description("Start, Resume, Pause, Stop a GraphOwner's behaviour")]
	public class GraphOwnerControl : ActionTask<GraphOwner>
	{
		public enum Control
		{
			StartBehaviour,
			StopBehaviour,
			PauseBehaviour
		}

		public Control control;

		public bool waitActionFinish;

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

		[IteratorStateMachine(typeof(<YieldDo>d__6))]
		private IEnumerator YieldDo()
		{
			return null;
		}

		private void Do()
		{
		}

		protected override void OnStop()
		{
		}
	}
}
