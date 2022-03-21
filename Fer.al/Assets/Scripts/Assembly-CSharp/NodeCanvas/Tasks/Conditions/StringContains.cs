using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("â\u009c« Blackboard")]
	public class StringContains : ConditionTask
	{
		[RequiredField]
		[BlackboardOnly]
		public BBParameter<string> targetString;

		public BBParameter<string> checkString;

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
