using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace StrayTech
{
	public abstract class CameraStateModifierBase : MonoBehaviour
	{
		[SerializeField]
		[Tooltip("Duration of the transition into the enabled state.")]
		private float _transitionIntoEnabledDuration;

		[SerializeField]
		[Tooltip("Duration of the transition into the disabled state.")]
		private float _transitionIntoDisabledDuration;

		[SerializeField]
		[Tooltip("The animation clip to play. (Needs to be a Legacy Animation Clip)")]
		private int _priority;

		private bool _transitioning;

		private float _transitionLerpT;

		protected Vector3 _cameraTargetPosition;

		protected Quaternion _cameraTargetRotation;

		public abstract string Name { get; }

		public int Priority
		{
			get
			{
				return default(int);
			}
		}

		public float TransitionLerpT
		{
			get
			{
				return default(float);
			}
		}

		public virtual void Initialize()
		{
		}

		protected abstract void CalculateModification(ICameraState cameraState, float deltaTime);

		public void ModifiyCamera(ICameraState cameraState, float deltaTime)
		{
		}

		public virtual bool Enable()
		{
			return default(bool);
		}

		public virtual void Disable()
		{
		}

		public virtual void Cleanup()
		{
		}

		[IteratorStateMachine(typeof(<DoTransitionIn>d__19))]
		private IEnumerator DoTransitionIn(float transitionDuration)
		{
			return null;
		}

		[IteratorStateMachine(typeof(<DoTransitionOut>d__20))]
		private IEnumerator DoTransitionOut(float transitionDuration)
		{
			return null;
		}
	}
}
