using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("WildWorks/Player")]
	[Description("Is the player in range")]
	public class LocalPlayerInRange : ConditionTask<Transform>
	{
		public BBParameter<float> range;

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

		public override void OnDrawGizmosSelected()
		{
		}
	}
}
