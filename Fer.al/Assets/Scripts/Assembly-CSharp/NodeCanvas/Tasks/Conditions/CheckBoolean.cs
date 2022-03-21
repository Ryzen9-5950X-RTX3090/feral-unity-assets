using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("â\u009c« Blackboard")]
	public class CheckBoolean : ConditionTask
	{
		[BlackboardOnly]
		public BBParameter<bool> valueA;

		public BBParameter<bool> valueB;

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
