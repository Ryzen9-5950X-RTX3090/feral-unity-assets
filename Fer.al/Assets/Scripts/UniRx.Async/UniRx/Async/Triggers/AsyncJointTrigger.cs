using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Threading;
using UnityEngine;

namespace UniRx.Async.Triggers
{
	[DisallowMultipleComponent]
	public class AsyncJointTrigger : AsyncTriggerBase
	{
		private AsyncTriggerPromise<float> onJointBreak;

		private AsyncTriggerPromiseDictionary<float> onJointBreaks;

		private AsyncTriggerPromise<Joint2D> onJointBreak2D;

		private AsyncTriggerPromiseDictionary<Joint2D> onJointBreak2Ds;

		protected override IEnumerable<ICancelablePromise> GetPromises()
		{
			return null;
		}

		private void OnJointBreak(float breakForce)
		{
		}

		public UniTask<float> OnJointBreakAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<float>);
		}

		private void OnJointBreak2D(Joint2D brokenJoint)
		{
		}

		public UniTask<Joint2D> OnJointBreak2DAsync([Optional] CancellationToken cancellationToken)
		{
			return default(UniTask<Joint2D>);
		}
	}
}
