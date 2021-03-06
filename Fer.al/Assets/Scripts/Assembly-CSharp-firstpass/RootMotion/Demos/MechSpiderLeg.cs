using System.Collections;
using System.Runtime.CompilerServices;
using RootMotion.FinalIK;
using UnityEngine;

namespace RootMotion.Demos
{
	public class MechSpiderLeg : MonoBehaviour
	{
		public MechSpider mechSpider;

		public MechSpiderLeg unSync;

		public Vector3 offset;

		public float minDelay;

		public float maxOffset;

		public float stepSpeed;

		public float footHeight;

		public float velocityPrediction;

		public float raycastFocus;

		public AnimationCurve yOffset;

		public ParticleSystem sand;

		private IK ik;

		private float stepProgress;

		private float lastStepTime;

		private Vector3 defaultPosition;

		private RaycastHit hit;

		public bool isStepping
		{
			get
			{
				return default(bool);
			}
		}

		public Vector3 position
		{
			get
			{
				return default(Vector3);
			}
			set
			{
			}
		}

		private void Awake()
		{
		}

		private void Start()
		{
		}

		private Vector3 GetStepTarget(out bool stepFound, float focus, float distance)
		{
			return default(Vector3);
		}

		private void OnEnable()
		{
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(<Step>d__26))]
		private IEnumerator Step(Vector3 stepStartPosition, Vector3 targetPosition)
		{
			return null;
		}
	}
}
