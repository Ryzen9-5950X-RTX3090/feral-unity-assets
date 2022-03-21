using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace FIMSpace.FSpine
{
	public class FSpine_AnimatorPerchance : MonoBehaviour
	{
		[Serializable]
		public class FSpine_Point
		{
			public Vector3 Position;

			public Quaternion Rotation;

			public Vector3 TransformDirection(Vector3 dir)
			{
				return default(Vector3);
			}
		}

		[Serializable]
		public class FSpine_FixingSet
		{
			public List<Vector3> Current;

			public List<Vector3> Initial;

			public List<Vector3> Rounded;

			public List<Vector3> Reversed;

			public List<Vector3> RoundedReversed;

			internal void AddToAllNormal(Vector3 v)
			{
			}

			internal FSpine_FixingSet Init()
			{
				return null;
			}
		}

		[Tooltip("Spine bones chain, always go from parent to children.")]
		public List<Transform> SpineTransforms;

		private List<FSpine_Point> proceduralPoints;

		private List<FSpine_Point> helperProceduralPoints;

		private List<float> initialBoneDistances;

		[Tooltip("Blend between procedural and animator's keyframed animation")]
		[Range(0f, 1f)]
		public float BlendToOriginal;

		[Tooltip("If your spine lead bone is in beggining of your hierarchy chain, toggle it. Component's gizmos can help you out to define which bone should be leading (head gizmo when you switch this toggle).")]
		public bool ReversedLeadBone;

		private bool reversedChangeFlag;

		[Tooltip("Rare case, but sometimes when you use reversed lead bone option, it can roll your bones, it can happen when something unusual is happening in skeleton's hierarchy, but toggling this option everything should be fixed")]
		public bool RolledBones;

		private Vector3 lookUp;

		private bool rolledChangeFlag;

		[Tooltip("If you want tail animator motion to be connected with keyframed animation motion, don't use this when your object isn't animated")]
		public bool ConnectWithAnimator;

		[Tooltip("When animation should be hardly precise to main transform motion, untoggle it when you using it only on part of chractesr body, not on main movement transform")]
		public bool AnchoredSpine;

		[Tooltip("Connecting root translation to given transform, useful when you use limb, then you should put here parent of first bone and probably enable QueueToLastUpdate")]
		public Transform AnchorRoot;

		[Tooltip("Useful when you use few spine animators and want to rely on animated position and rotation by other spine animator")]
		public bool QueueToLastUpdate;

		[Tooltip("When your keyframed animation don't have keys on position track (common case) or you using not animated object with spine animator")]
		public bool PositionsNotAnimated;

		public List<bool> SelectivePosNotAnimated;

		[Tooltip("When your keyframed animation don't have keys on rotation track (rare case) or you using not animated object with spine animator")]
		public bool RotationsNotAnimated;

		public List<bool> SelectiveRotNotAnimated;

		private int leadingBoneIndex;

		private int endingBoneIndex;

		private int reverser;

		private List<FSpine_Point> staticCoordinates;

		private List<FSpine_Point> staticCoordinatesBaseRef;

		private List<FSpine_Point> referencePoses;

		private FSpine_FixingSet spineLookDirectionsSet;

		[Tooltip("Component is made to work universally on many sets of skeletons, but there can exist small offsets which you can correct using this variables")]
		public List<Vector3> ManualRotationOffsets;

		[Tooltip("Component is made to work universally on many sets of skeletons, but there can exist small offsets which you can correct using this variables")]
		public List<Vector3> ManualPositionOffsets;

		[Tooltip("When start we doing precise calculations for fixing rotations, but in most cases rounding this values is doing job better")]
		public bool RoundCorrection;

		private bool wasRoundCorrection;

		[Tooltip("Often when you drop model to scene, it's initial pose is much different than animations, which causes problems, this toggle solves it at start")]
		public bool StartAfterTPose;

		[Tooltip("Adding some extra correction to positions and rotations when your skeleton have some unusual stuff going on in hierarchy")]
		public bool RefinedCorrection;

		private Quaternion initialRotation;

		private Vector3 previousScale;

		private Transform[] anchorHelpers;

		private Transform anchorsContainer;

		private bool wasSourceAnimation;

		private List<float> StaticYOffsets;

		private bool initialized;

		private Vector3 previousPos;

		[Range(0f, 1f)]
		[Tooltip("If animation of changing segments position should be smoothed - creating a little gumy effect")]
		public float PosSmoother;

		[Range(0f, 1f)]
		[Tooltip("If animation of changing segments rotation should be smoothed - making it more soft, but don't overuse it")]
		public float RotSmoother;

		[Range(5f, 180f)]
		[Tooltip("Limiting rotation angle difference between each segment of spine but consider using StraightenSpeed variable for smoother effect")]
		public float AngleLimit;

		[Range(0f, 1f)]
		[Tooltip("Smoothing how fast limiting should make segments go back to marginal pose")]
		public float LimitSmoother;

		[Range(0f, 15f)]
		[Tooltip("How fast spine should be rotated to straight pose when it moves, higher angle limit - straigtening should be lower (behave different than GoBackSpeed)")]
		public float StraightenSpeed;

		public bool TurboStraighten;

		[Tooltip("Spine going back to straight position with choosed speed intensity")]
		[Range(0f, 1f)]
		public float GoBackSpeed;

		[Tooltip("<! Most models can not need this !> Offset for bones rotations, thanks to that animation is able to rotate to segments in a correct way, like from center of mass")]
		public Vector3 PivotOffset;

		private void Init()
		{
		}

		protected void ComputePredefinedVariables()
		{
		}

		protected virtual void PrepareSpinePoints()
		{
		}

		protected virtual void ConfigureBonesTransforms()
		{
		}

		protected void Start()
		{
		}

		[IteratorStateMachine(typeof(<InitTPoseStartOffset>d__52))]
		private IEnumerator InitTPoseStartOffset()
		{
			return null;
		}

		private void UpdateReverseHelpVariables()
		{
		}

		private void ReposeSpineAccord()
		{
		}

		private void ReposeSpine()
		{
		}

		private void LateUpdate()
		{
		}

		protected virtual void CalculateMotion()
		{
		}

		private void CalculateSpineBehaviourPosition(int index)
		{
		}

		private void CalculateSpineBehaviourRotation(int index)
		{
		}

		protected virtual Quaternion CalculateTargetRotation([Optional] FSpine_Point otherSpinePoint, [Optional] FSpine_Point currentSpinePoint, int index = 0)
		{
			return default(Quaternion);
		}

		private void RefreshRefDirsOnReverse()
		{
		}

		private void RefreshDistances()
		{
		}

		private float SmootherValue(float val)
		{
			return default(float);
		}

		protected Vector3 RoundPosDiff(Vector3 pos, int digits = 1)
		{
			return default(Vector3);
		}

		private Vector3 RoundToBiggestValue(Vector3 vec)
		{
			return default(Vector3);
		}

		private void DrawFatRay(Vector3 origin, Vector3 dir)
		{
		}

		private void DrawFatLine(Vector3 origin, Vector3 dir)
		{
		}

		public void RefreshSelectivePosNotAnimated()
		{
		}

		public void RefreshSelectiveRotNotAnimated()
		{
		}

		public void RefreshManualPosOffs()
		{
		}

		public void RefreshManualRotOffs()
		{
		}

		public void OnDestroy()
		{
		}

		public void TryAutoCorrect([Optional] Transform head)
		{
		}

		public void DevLog()
		{
		}

		[IteratorStateMachine(typeof(<ReactivateMe>d__77))]
		public IEnumerator ReactivateMe()
		{
			return null;
		}
	}
}
