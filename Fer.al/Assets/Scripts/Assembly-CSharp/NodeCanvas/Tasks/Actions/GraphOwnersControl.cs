using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Name("Control Multiple Graph Owners", 0)]
	[Category("â\u009c« Utility")]
	[Description("Start, Resume, Pause, Stop multiple GraphOwner's behaviour")]
	public class GraphOwnersControl : ActionTask
	{
		public enum Control
		{
			StartBehaviour,
			StopBehaviour,
			PauseBehaviour
		}

		public Control control;

		public BBParameter<GraphOwner[]> GraphOwners;

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

		[IteratorStateMachine(typeof(<YieldDo>d__7))]
		private IEnumerator YieldDo(GraphOwner inGO)
		{
			return null;
		}

		private void Do(GraphOwner inGO)
		{
		}
	}
}
