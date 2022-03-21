using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Transform")]
	[Description("Rotates local player to look at a transform.")]
	public class LocalPlayerLookAtTransform : ActionTask<Transform>
	{
		public BBParameter<bool> _lookAtIgnoreY;

		public BBParameter<Vector3> transformOffset;

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

		[IteratorStateMachine(typeof(<LookAt>d__7))]
		private IEnumerator LookAt()
		{
			return null;
		}
	}
}
