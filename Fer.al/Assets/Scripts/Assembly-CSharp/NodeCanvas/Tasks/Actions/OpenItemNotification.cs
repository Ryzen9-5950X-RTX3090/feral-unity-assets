using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/UI")]
	public class OpenItemNotification : ActionTask
	{
		public string imageDefId;

		public string itemNameDefId;

		public int quantity;

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
