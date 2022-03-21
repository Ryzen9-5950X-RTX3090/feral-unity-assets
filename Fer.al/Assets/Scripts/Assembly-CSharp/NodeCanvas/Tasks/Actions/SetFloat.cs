using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("â\u009c« Blackboard")]
	[Description("Set a blackboard float variable")]
	public class SetFloat : ActionTask
	{
		[BlackboardOnly]
		public BBParameter<float> valueA;

		public OperationMethod Operation;

		public BBParameter<float> valueB;

		public bool perSecond;

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
