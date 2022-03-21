using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Network")]
	[Description("Server script - Starts or stops a timer, or runs actions in an actors current state.")]
	public class NetworkObjectStartStop : NetworkActionTask<NetworkedObjectInfo>
	{
		public enum EAction
		{
			start,
			stop
		}

		public EAction action;

		protected override string info
		{
			get
			{
				return null;
			}
		}
	}
}
