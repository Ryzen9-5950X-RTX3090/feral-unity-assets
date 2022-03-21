using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("WildWorks/Attributes")]
	[Description("How much of the attribute does the player has? ie: intelligence")]
	public class CheckAttribute : ConditionTask
	{
		public BBParameter<string> attributeDefId;

		public CompareMethod checkType;

		public BBParameter<int> valueB;

		public int valueA
		{
			get
			{
				return default(int);
			}
		}

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
