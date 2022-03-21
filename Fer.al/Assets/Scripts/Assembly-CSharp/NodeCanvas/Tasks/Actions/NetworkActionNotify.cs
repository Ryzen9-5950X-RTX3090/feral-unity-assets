using NodeCanvas.DialogueTrees;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Network")]
	[Description("Server script - Send a notify command")]
	public class NetworkActionNotify : NetworkActionTask
	{
		public Statement statement;

		protected override string info
		{
			get
			{
				return null;
			}
		}
	}
}
