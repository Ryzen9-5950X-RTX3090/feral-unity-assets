using System.Collections;
using System.Runtime.CompilerServices;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Quest")]
	[Description("Give Loot to players from a list")]
	public class SocialExpanseLockedChestGiveLoot : NetworkActionTask
	{
		public bool closeWindowToContinue;

		public Interactable.EItemType chestType;

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

		[IteratorStateMachine(typeof(<AutoClose>d__6))]
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

		public string GetListId()
		{
			return null;
		}
	}
}
