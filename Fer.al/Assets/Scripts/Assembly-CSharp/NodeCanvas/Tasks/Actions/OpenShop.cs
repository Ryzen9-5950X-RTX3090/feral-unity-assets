using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Shop")]
	[Description("Server script - Open Shop Window.")]
	public class OpenShop : NetworkActionTask
	{
		public string shopName;

		public string shopDefID;

		protected override string info
		{
			get
			{
				return null;
			}
		}
	}
}
