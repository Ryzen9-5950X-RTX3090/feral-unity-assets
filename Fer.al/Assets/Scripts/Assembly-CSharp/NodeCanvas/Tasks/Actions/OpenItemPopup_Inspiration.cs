using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/UI")]
	[Description("Open an Inspiration Item Popup Window")]
	public class OpenItemPopup_Inspiration : ActionTask
	{
		public string inspirationDefId;

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

		public void OnWindowClosed(UI_Window inWindow)
		{
		}
	}
}
