using System.Collections.Generic;
using UnityEngine;

namespace FIMSpace.FTail
{
	public class FTail_AnimatorLegacy : FTail_Animator
	{
		public SkinnedMeshRenderer BonesOwner;

		[Tooltip("We can blend bones to move like animator movement or just tail animator motion")]
		[Range(0f, 1f)]
		public float BlendToOriginal;

		protected List<Transform> newSkinnedBones;

		protected List<Transform> previousSkinnedBones;

		protected override void Reset()
		{
		}

		protected override void Init()
		{
		}

		protected override void ConfigureBonesTransforms()
		{
		}

		protected override void MotionCalculations()
		{
		}

		public override void CalculateOffsets()
		{
		}

		public void TryFindBonesOwner()
		{
		}
	}
}
