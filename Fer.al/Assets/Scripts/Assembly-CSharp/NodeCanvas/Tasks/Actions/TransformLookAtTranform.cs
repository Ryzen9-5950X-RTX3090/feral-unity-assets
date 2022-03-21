using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Transform")]
	[Description("Rotates a transform to look at the specified transform")]
	public class TransformLookAtTranform : ActionTask<Transform>
	{
		public BBParameter<Transform> transformToLookAt;

		public BBParameter<bool> ignoreTransformY;

		public BBParameter<Vector3> lookAtOffset;

		public BBParameter<float> duration;

		public BBParameter<bool> waitToContinue;

		private Vector3 startPos;

		private Vector3 endPos;

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

		[IteratorStateMachine(typeof(<LookAt>d__10))]
		private IEnumerator LookAt()
		{
			return null;
		}
	}
}
