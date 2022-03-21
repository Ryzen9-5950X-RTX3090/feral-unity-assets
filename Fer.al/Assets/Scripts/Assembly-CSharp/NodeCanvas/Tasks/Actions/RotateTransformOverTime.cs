using System.Collections;
using System.Runtime.CompilerServices;
using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Category("WildWorks/Transform")]
	[Description("rotates a transform over time")]
	public class RotateTransformOverTime : ActionTask<Transform>
	{
		public BBParameter<Vector3> rotation;

		public BBParameter<float> duration;

		public BBParameter<bool> additive;

		public BBParameter<bool> waitToContinue;

		private Vector3 endRot;

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

		[IteratorStateMachine(typeof(<RotateIt>d__8))]
		private IEnumerator RotateIt()
		{
			return null;
		}
	}
}
