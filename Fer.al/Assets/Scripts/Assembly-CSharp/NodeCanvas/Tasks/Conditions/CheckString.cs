using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("â\u009c« Blackboard")]
	public class CheckString : ConditionTask
	{
		[BlackboardOnly]
		public BBParameter<string> valueA;

		public BBParameter<string> valueB;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override bool OnCheck()
		{
			return default(bool);
		}
	}
}
