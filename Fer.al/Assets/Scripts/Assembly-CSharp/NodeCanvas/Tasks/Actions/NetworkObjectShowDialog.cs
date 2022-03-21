using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Network")]
	[Description("Server script - Shows the dialog tree in the dialogueTreeController of the networked object info on the game object that this behavior tree is on at the index specified")]
	public class NetworkObjectShowDialog : NetworkActionTask
	{
		public enum EDialogType
		{
			Ask,
			AskAll
		}

		public EDialogType dialogType;

		public BBParameter<int> dialogIndex;

		private NetworkedObjectInfo noi;

		protected override string info
		{
			get
			{
				return null;
			}
		}
	}
}
