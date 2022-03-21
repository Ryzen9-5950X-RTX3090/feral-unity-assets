using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[Category("WildWorks/Player")]
	[Description("Is the player on the specified collider")]
	public class LocalPlayerOverCollider : ConditionTask<Collider>
	{
		public BBParameter<float> checkRate;

		private float _checkRate;

		private CharacterController charController;

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
