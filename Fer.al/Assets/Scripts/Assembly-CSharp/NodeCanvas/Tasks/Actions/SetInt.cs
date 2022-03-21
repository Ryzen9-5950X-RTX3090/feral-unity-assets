using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Name("Set Integer", 0)]
	[Category("â\u009c« Blackboard")]
	[Description("Set a blackboard integer variable")]
	public class SetInt : ActionTask
	{
		[BlackboardOnly]
		public BBParameter<int> valueA;

		public OperationMethod Operation;

		public BBParameter<int> valueB;

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
	}
}
