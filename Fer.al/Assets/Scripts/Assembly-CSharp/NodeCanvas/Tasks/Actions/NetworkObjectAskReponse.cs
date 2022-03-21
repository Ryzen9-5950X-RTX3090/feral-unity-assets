using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Network/Messages")]
	[Description("Send a qaskr network message")]
	public class NetworkObjectAskReponse : ActionTask<NetworkedObjectInfo>
	{
		public enum EAskResponse
		{
			yes,
			no
		}

		public EAskResponse askResponse;

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
