using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("Input")]
	public class WaitMousePick : ActionTask
	{
		public enum ButtonKeys
		{
			Left,
			Right,
			Middle
		}

		public ButtonKeys buttonKey;

		public LayerMask mask;

		[BlackboardOnly]
		public BBParameter<GameObject> saveObjectAs;

		[BlackboardOnly]
		public BBParameter<float> saveDistanceAs;

		[BlackboardOnly]
		public BBParameter<Vector3> savePositionAs;

		private int buttonID;

		private RaycastHit hit;

		protected override string info
		{
			get
			{
				return null;
			}
		}

		protected override void OnUpdate()
		{
		}
	}
}
