using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Conditions
{
	[Name("Target In Line Of Sight 2D", 0)]
	[Category("GameObject")]
	[Description("Check of agent is in line of sight with target by doing a linecast and optionaly save the distance")]
	public class CheckLOS2D : ConditionTask<Transform>
	{
		[RequiredField]
		public BBParameter<GameObject> LOSTarget;

		public BBParameter<LayerMask> layerMask;

		[BlackboardOnly]
		public BBParameter<float> saveDistanceAs;

		[GetFromAgent]
		protected Collider2D agentCollider;

		private RaycastHit2D[] hits;

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
