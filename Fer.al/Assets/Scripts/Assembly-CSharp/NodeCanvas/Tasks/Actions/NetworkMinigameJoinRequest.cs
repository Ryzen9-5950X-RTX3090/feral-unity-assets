using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Network/Messages")]
	[Description("Send a Minigame Join Request")]
	public class NetworkMinigameJoinRequest : ActionTask
	{
		public string levelDefId;

		public bool skipPopUp;

		public bool roomJoin;

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
	}
}
