using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Quest")]
	[Description("Give Embers to a Player")]
	public class QuestGiveEmbers : NetworkActionTask
	{
		public BBParameter<int> emberAmount;

		protected override string info
		{
			get
			{
				return null;
			}
		}
	}
}
