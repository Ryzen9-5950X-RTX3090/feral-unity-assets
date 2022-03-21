using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Quest/Messages")]
	[Description("Server script - Triggers a quest exit")]
	public class QuestOnExit : NetworkActionTask
	{
		public BBParameter<int> cmdId;

		protected override string info
		{
			get
			{
				return null;
			}
		}
	}
}
