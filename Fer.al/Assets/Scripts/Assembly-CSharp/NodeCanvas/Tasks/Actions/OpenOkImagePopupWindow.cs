using NodeCanvas.DialogueTrees;
using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/UI")]
	[Description("Open an Ok Image Popup Window")]
	public class OpenOkImagePopupWindow : ActionTask
	{
		public Statement statementHeader;

		public Statement statementMessageTitle;

		public Statement statementMessageBody;

		public Statement statementOkButton;

		public string imageDefId;

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
