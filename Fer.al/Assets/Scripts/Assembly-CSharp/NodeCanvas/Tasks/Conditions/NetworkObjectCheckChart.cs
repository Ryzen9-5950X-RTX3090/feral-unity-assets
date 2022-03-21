using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("WildWorks/Network")]
	[Description("Check a Global Chart value. Will not work client side like the NetworkObjectCheckState does.")]
	public class NetworkObjectCheckChart : NetworkConditionTask<NetworkedObjectInfo>
	{
		public CompareMethod compareMethod;

		public string chartDefName;

		public string chartDefID;

		protected override string info
		{
			get
			{
				return null;
			}
		}
	}
}
