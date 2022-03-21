using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("â\u009c« Blackboard")]
	public class SetVariable<T> : ActionTask
	{
		[BlackboardOnly]
		public BBParameter<T> valueA;

		public BBParameter<T> valueB;

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
