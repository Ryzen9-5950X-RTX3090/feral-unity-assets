using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Transform")]
	[Description("Rotates a transform to look at local player")]
	public class TransformLookAtLocalPlayer : ActionTask<Transform>
	{
		public BBParameter<Vector3> playerOffset;

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

		[IteratorStateMachine(typeof(<LookAt>d__6))]
		private IEnumerator LookAt()
		{
			return null;
		}
	}
}
