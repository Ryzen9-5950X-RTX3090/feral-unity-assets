using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Network")]
	[Description("Server script - Executes server actions based on percentages.")]
	public class NetworkObjectMake : NetworkActionTask<NetworkedObjectInfo>
	{
		public BBParameter<string> makeNodeTag;

		protected override string info
		{
			get
			{
				return null;
			}
		}
	}
}
