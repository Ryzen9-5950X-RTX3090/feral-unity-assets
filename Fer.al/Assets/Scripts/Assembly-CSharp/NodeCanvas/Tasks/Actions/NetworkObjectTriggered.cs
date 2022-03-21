using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Network/Messages")]
	[Description("Send a oaf network message to the server. NOTE: Due to position checks on the server, the game object this is attached to must be near the client that calls it.")]
	public class NetworkObjectTriggered : ActionTask<NetworkedObjectInfo>
	{
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
