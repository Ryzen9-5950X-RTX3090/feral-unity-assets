using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("â\u009c« Blackboard")]
	public class CheckInt : ConditionTask
	{
		[BlackboardOnly]
		public BBParameter<int> valueA;

		public CompareMethod checkType;

		public BBParameter<int> valueB;

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
