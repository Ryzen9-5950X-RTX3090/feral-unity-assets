using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using UnityEngine;

namespace FIMSpace.FSpine
{
	public class FSpineAnimator : MonoBehaviour
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

			public List<Vector3> Unified;

			public List<Vector3> SetUnified(List<Vector3> toUnify)
			{
				return null;
			}

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

		private List<FSpine_Point> ProceduralReferencePose;

		private List<FSpine_Point> helperProceduralPoints;

		private List<float> initialBoneDistances;

		[Tooltip("Blend between procedural and animator's keyframed animation")]
		[Range(0f, 1f)]
		public float BlendToOriginal;

		[Tooltip("If your spine lead bone is in beggining of your hierarchy chain, toggle it. Component's gizmos can help you out to define which bone should be leading (head gizmo when you switch this toggle).")]
		public bool LastBoneLeading;

		private bool reversedChangeFlag;

		private Vector3 lookUp;

		[Tooltip("Not yet figured out how to detect when rotations for other skeleton axis orientations set is going up/down instead of down/up. If you encounter hevaiour like that, toggle this.")]
		public bool InversedVerticalRotation;

		[Tooltip("If you want tail animator motion to be connected with keyframed animation motion, don't use this when your object isn't animated")]
		public bool ConnectWithAnimator;

		[Tooltip("In most cases it work just right with this option disabled, but in some situations it can give you better results when you enable animating leading bone")]
		public bool AnimateLeadingBone;

		[Tooltip("If animated leading bone translation should be added after spine motion - to use in case model is using position frames animation's grounding")]
		public bool LeadingAnimateAfterMotion;

		[Tooltip("If you using animate physics on animator you should set this variable enabled")]
		public bool PhysicalUpdate;

		[Tooltip("When animation should be hardly precise to main transform motion, untoggle it when you using it only on part of chractesr body, not on main movement transform")]
		public bool AnchorToThis;

		[Tooltip("Connecting root translation to given transform, useful when you use limb, then you should put here parent of first bone and probably enable QueueToLastUpdate")]
		public Transform AnchorRoot;

		[Tooltip("If you find out that debug tail pose have wrong rotation")]
		public Vector3 CustomAnchorRotationOffset;

		[Tooltip("Useful when you use few spine animators and want to rely on animated position and rotation by other spine animator")]
		public bool QueueToLastUpdate;

		[Tooltip("When your keyframed animation don't have keys on position track (common case) or you using not animated object with spine animator")]
		public bool PositionsNotAnimated;

		public List<bool> SelectivePosNotAnimated;

		[Tooltip("When your keyframed animation don't have keys on rotation track (rare case) or you using not animated object with spine animator")]
		public bool RotationsNotAnimated;

		public List<bool> SelectiveRotNotAnimated;

		private int leadingBoneIndex;

		private int reverser;

		private int adjuster;

		private List<FSpine_Point> staticCoordinates;

		private FSpine_FixingSet spineLookDirectionsSet;

		[Tooltip("Advanced option, when some of your spine bones going in opposite way that they should, you can adjust it here sometimes")]
		public List<Vector3> lookDirectionsAdditiveCorrection;

		[Tooltip("Component is made to work universally on many sets of skeletons, but there can exist small offsets which you can correct using this variables")]
		public List<Vector3> ManualRotationOffsets;

		[Tooltip("Component is made to work universally on many sets of skeletons, but there can exist small offsets which you can correct using this variables")]
		public List<Vector3> ManualPositionOffsets;

		[Tooltip("When start we doing precise calculations for fixing rotations, but in most cases rounding this values is doing job better")]
		public bool RoundCorrection;

		private bool wasRoundCorrection;

		[Tooltip("Using only one axis correction direction for all segments")]
		public bool UnifyCorrection;

		private bool wasUnified;

		[Tooltip("Often when you drop model to scene, it's initial pose is much different than animations, which causes problems, this toggle solves it at start")]
		public bool StartAfterTPose;

		private Vector3 previousScale;

		private Transform[] anchorHelpers;

		private Transform anchorsContainer;

		private bool wasSourceAnimation;

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

		[Tooltip("Sometimes offsetting model's pivot position gives better results using spine animator, offset forward axis so front legs are in centrum and see the difference (generating additional transform inside hierarchy)")]
		public Vector3 MainPivotOffset;

		[HideInInspector]
		public Transform mainPivotOffsetTransform;

		[Tooltip("<! Most models can not need this !> Offset for bones rotations, thanks to that animation is able to rotate to segments in a correct way, like from center of mass")]
		public Vector3 SegmentsPivotOffset;

		[Tooltip("Multiplies distance value between bones segments - can be useful for use with humanoid skeletons")]
		public float DistancesMultiplier;

		public Transform rotationRef;

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

		private void OnEnable()
		{
		}

		private void OnDisable()
		{
		}

		protected void Start()
		{
		}

		[IteratorStateMachine(typeof(<InitTPoseStartOffset>d__59))]
		private IEnumerator InitTPoseStartOffset()
		{
			return null;
		}

		private void UpdateReverseHelpVariables()
		{
		}

		private void ReposeSpine()
		{
		}

		private void LateUpdate()
		{
		}

		[IteratorStateMachine(typeof(<LateFixedUpdate>d__63))]
		private IEnumerator LateFixedUpdate()
		{
			return null;
		}

		private void SpineMotion()
		{
		}

		private FSpine_Point GetLeadingBoneCoordinates()
		{
			return null;
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

		private void DrawBoneLine(Vector3 origin, Vector3 dir)
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

		private void RestoreBasePivotChildren()
		{
		}

		private void OnValidate()
		{
		}

		private void RefreshDifferenceReference()
		{
		}

		public void TryAutoCorrect([Optional] Transform head)
		{
		}

		public void DevLog()
		{
		}
	}
}
