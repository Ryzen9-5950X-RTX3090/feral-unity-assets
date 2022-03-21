using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("â\u009c« Blackboard")]
	[Description("Set a blackboard boolean variable")]
	public class SetBoolean : ActionTask
	{
		public enum BoolSetModes
		{
			False,
			True,
			Toggle
		}

		[RequiredField]
		[BlackboardOnly]
		public BBParameter<bool> boolVariable;

		public BoolSetModes setTo;

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
