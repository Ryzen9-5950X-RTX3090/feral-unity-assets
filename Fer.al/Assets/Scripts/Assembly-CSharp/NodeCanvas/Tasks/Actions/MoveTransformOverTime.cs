using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Transform")]
	[Description("Moves a tansform to a specified Vector")]
	public class MoveTransformOverTime : ActionTask<Transform>
	{
		public enum MoveToMode
		{
			LocalPlayer,
			Position,
			GameObject
		}

		public MoveToMode moveTo;

		[ShowIf("moveTo", 0)]
		public BBParameter<Vector3> localPlayerOffset;

		[ShowIf("moveTo", 1)]
		public BBParameter<Vector3> position;

		[ShowIf("moveTo", 2)]
		public BBParameter<Transform> targetGameObject;

		[ShowIf("moveTo", 2)]
		public BBParameter<Vector3> gameObjectOffset;

		public BBParameter<float> duration;

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

		[IteratorStateMachine(typeof(<Move>d__11))]
		private IEnumerator Move(Vector3 inEnd)
		{
			return null;
		}
	}
}
