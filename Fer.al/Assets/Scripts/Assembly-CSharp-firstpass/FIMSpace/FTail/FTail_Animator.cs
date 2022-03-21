using UnityEngine;

namespace FIMSpace.FTail
{
	public class FTail_Animator : FTail_AnimatorBase
	{
		public bool UseWaving;

		[Tooltip("Adding some variation to waving animation")]
		public bool CosinusAdd;

		public float WavingSpeed;

		public float WavingRange;

		public Vector3 WavingAxis;

		public Vector3 TailRotationOffset;

		[Tooltip("Disconnecting whole bones chain inside your model (excluding first bone) - this helps motion be more free and independent from some factors related to hierarchy, it is not recommended to do - only when needed")]
		public bool DisconnectTransforms;

		protected static Transform disconnectedContainer;

		protected Transform localDisconnectedContainer;

		protected float waveTime;

		protected float cosTime;

		private int RefreshCounter;

		protected override void Init()
		{
		}

		protected virtual void WavingCalculations()
		{
		}

		public override void CalculateOffsets()
		{
		}

		protected override void ConfigureBonesTransforms()
		{
		}

		protected Transform GetDisconnectedContainer()
		{
			return null;
		}

		internal virtual void Update()
		{
		}

		internal virtual void LateUpdate()
		{
		}

		internal virtual void FixedUpdate()
		{
		}

		protected override void OnDestroy()
		{
		}
	}
}
