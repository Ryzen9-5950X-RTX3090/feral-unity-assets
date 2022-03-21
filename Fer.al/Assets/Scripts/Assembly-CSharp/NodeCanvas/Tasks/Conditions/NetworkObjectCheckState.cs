using NodeCanvas.Framework;
using ParadoxNotion;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("WildWorks/Network")]
	[Description("Check a network objects state. This gets exported out if this dialog tree is called from a networked object info, but it can also be used for client side checks.")]
	public class NetworkObjectCheckState : NetworkConditionTask<NetworkedObjectInfo>
	{
		public CompareMethod checkType;

		public BBParameter<int> checkValue;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override bool OnCheck()
		{
			return default(bool);
		}
	}
}
