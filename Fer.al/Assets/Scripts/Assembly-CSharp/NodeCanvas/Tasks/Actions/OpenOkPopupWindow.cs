using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/UI")]
	public class OpenOkPopupWindow : ActionTask
	{
		public Statement statementTitle;

		public Statement statementMessage;

		public Statement statementOkButton;

		public BBParameter<bool> waitToContinue;

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

		public void OkClicked()
		{
		}
	}
}
