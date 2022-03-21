using System.Collections;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Quest")]
	[Description("Give Loot to all Players - similar to the pick gift on the web")]
	public class QuestGiveLoot : NetworkActionTask
	{
		public string lootName;

		public string lootDefID;

		public bool isLinearQuestReward;

		public bool closeWindowToContinue;

		private bool _itemPopupWindowOpen;

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

		[IteratorStateMachine(typeof(<AutoClose>d__8))]
		private IEnumerator AutoClose()
		{
			return null;
		}

		private void OnWindowOpened(WindowOpenedMessage inMessage)
		{
		}

		private void OnWindowClosed(WindowClosedMessage inMessage)
		{
		}
	}
}
