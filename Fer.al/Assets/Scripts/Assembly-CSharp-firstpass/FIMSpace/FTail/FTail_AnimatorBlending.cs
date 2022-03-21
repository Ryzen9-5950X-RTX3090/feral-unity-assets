using System.Collections.Generic;
using UnityEngine;

namespace FIMSpace.FTail
{
	public class FTail_AnimatorBlending : FTail_Animator
	{
		[Header("[ Animator Support Parameters ]")]
		[Tooltip("Blend source animation and tail animator")]
		[Range(0f, 1f)]
		public float BlendToOriginal;

		[Tooltip("Change it value when you want first bones to be not animated by tail animator, but by your keyframed animation")]
		[Range(0f, 1f)]
		public float BlendChainValue;

		[Tooltip("In most cases your animation could not have keyframes in position track, then you set tick here")]
		public bool PositionsNotAnimated;

		private float smoothChainBlend;

		private List<Vector3> staticPositions;

		protected override void Init()
		{
		}

		protected override void CoputeHelperVariables()
		{
		}

		protected override void Reset()
		{
		}

		internal override void Update()
		{
		}

		internal override void FixedUpdate()
		{
		}

		public override void CalculateOffsets()
		{
		}

		internal override void LateUpdate()
		{
		}

		protected override void SetTailTransformsFromPoints()
		{
		}
	}
}
