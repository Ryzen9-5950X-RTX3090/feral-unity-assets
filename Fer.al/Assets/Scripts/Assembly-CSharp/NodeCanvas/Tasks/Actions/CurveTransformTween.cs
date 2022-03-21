using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions
{
	[Name("Curve Tween", 0)]
	[Category("Movement/Direct")]
	public class CurveTransformTween : ActionTask<Transform>
	{
		public enum TransformMode
		{
			Position,
			Rotation,
			Scale
		}

		public enum TweenMode
		{
			Absolute,
			Additive
		}

		public enum PlayMode
		{
			Normal,
			PingPong
		}

		public TransformMode transformMode;

		public TweenMode mode;

		public PlayMode playMode;

		public BBParameter<Vector3> targetPosition;

		public BBParameter<AnimationCurve> curve;

		public BBParameter<float> time;

		private Vector3 original;

		private Vector3 final;

		private bool ponging;

		protected override void OnExecute()
		{
		}

		protected override void OnUpdate()
		{
		}
	}
}
