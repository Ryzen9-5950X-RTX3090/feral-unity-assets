using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("WildWorks/Inspiration")]
	[Description("Does the player own the inspiration?")]
	public class CheckOwnedInspiration : ConditionTask
	{
		public BBParameter<string> inspirationDefId;

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
