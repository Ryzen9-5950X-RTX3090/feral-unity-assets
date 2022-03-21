using NodeCanvas.Framework;
using ParadoxNotion.Design;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("WildWorks/Inventory")]
	[Description("Check the status of a enigma in a users inventory")]
	public class EnigmaInventoryCheck : ConditionTask
	{
		public enum EEnigmaStatus
		{
			Owned,
			Active,
			Complete
		}

		public EEnigmaStatus enigmaStatus;

		public string enigmaName;

		public string enigmaID;

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
