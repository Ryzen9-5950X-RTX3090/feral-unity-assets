using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Name("Get Variable To String", 0)]
	[Category("â\u009c« Blackboard")]
	public class GetToString : ActionTask
	{
		[BlackboardOnly]
		public BBParameter<object> variable;

		[BlackboardOnly]
		public BBParameter<string> toString;

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
