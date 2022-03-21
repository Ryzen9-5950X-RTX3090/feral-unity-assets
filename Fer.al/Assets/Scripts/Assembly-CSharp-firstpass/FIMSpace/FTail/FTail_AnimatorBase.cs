using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using FIMSpace.Basics;
using UnityEngine;

namespace FIMSpace.FTail
{
	public abstract class FTail_AnimatorBase : MonoBehaviour
	{
		public enum FTailColliders
		{
			Boxes,
			Spheres
		}

		protected class FTail_Point
		{
			public int index;

			public Vector3 Position;

			public Quaternion Rotation;

			public Vector3 InitialPosition;

			public Quaternion InitialRotation;

			public Vector3 InitialLossyScale;

			public Vector3 TransformDirection(Vector3 dir)
			{
				return default(Vector3);
			}
		}

		[Space]
		[Header("[ Auto detection if left empty ]")]
		[Space(-8f)]
		[Header("[ or put here first bone ]")]
		public List<Transform> TailTransforms;

		[Tooltip("When you want pin controll rotation motion to parent instead of first bone in chain")]
		public bool RootToParent;

		[Tooltip("When you want to use auto get when you assigning one bone inside inspector window")]
		public bool AutoGetWithOne;

		[Tooltip("Safe variable to correctly support dynamic scalling. Not changing much visually but preventing from incorrect scalling when bones inside your model have animated scale.")]
		public bool InitBeforeAnimator;

		protected List<FTail_Point> proceduralPoints;

		[Header("[ Tail behaviour params ]")]
		[Tooltip("Position speed is defining how fast tail segments will return to target position, it gives animation more gummy feeling if it's lower")]
		[Range(5f, 60f)]
		public float PositionSpeed;

		[Tooltip("Rotation speed is defining how fast tail segments will return to target rotation, it gives animation more lazy feeling if it's lower")]
		[Range(5f, 60f)]
		public float RotationSpeed;

		protected List<Transform> editorGizmoTailList;

		[Tooltip("Automatically changing some tweaking settings to make tail animation look correctly")]
		public bool UseAutoCorrectLookAxis;

		public bool FullCorrection;

		[Tooltip("Use this option when your model is rolling strangely when waving")]
		public bool RolledBones;

		public bool AnimateCorrections;

		public float StretchMultiplier;

		[Space]
		[Tooltip("Bones wrong rotations axis corrector")]
		[Space(8f)]
		public Vector3 AxisCorrection;

		public Vector3 AxisLookBack;

		[HideInInspector]
		public bool ExtraCorrectionOptions;

		public Vector3 ExtraFromDirection;

		public Vector3 ExtraToDirection;

		[Tooltip("This option adding TailReference component to all tail segments, so you can access this component from tail's segment transform")]
		public bool AddTailReferences;

		[Tooltip("Set update clock to LateUpdate if you want to use component over object with own animation")]
		public EFUpdateClock UpdateClock;

		[Tooltip("When you use Update or LateUpdate you can use smooth delta time, which can eliminate some chopping when framerate isn't stable")]
		public bool SmoothDeltaTime;

		[Tooltip("To use for example when your model is posed during animations much different than it's initial T-Pose (when you use 'Animate Corrections')")]
		public bool RefreshHelpers;

		[Tooltip("Useful when you use other components to affect bones hierarchy and you want this component to follow other component's changes")]
		public bool QueueToLastUpdate;

		[Tooltip("[Experimental] Using some simple calculations to make tail bend on colliders")]
		public bool UseCollision;

		public bool CollideWithOtherTails;

		public FTailColliders CollidersType;

		public AnimationCurve CollidersScale;

		public float CollidersScaleMul;

		public Vector3 BoxesDimensionsMul;

		public List<Collider> IgnoredColliders;

		public bool CollidersSameLayer;

		[Tooltip("If you add rigidbodies to each tail segment's collider, collision will work on everything but it will be less optimal, you don't have to add here rigidbodies but then you must have not kinematic rigidbodies on objects segments can collide")]
		public bool CollidersAddRigidbody;

		public LayerMask CollidersLayer;

		[Range(0f, 1f)]
		public float DifferenceScaleFactor;

		[Tooltip("If you want to simulate global additional force over tail animation, working not exacly like gravity but tries to mimic this with simple calculations")]
		public Vector2 GravityPower;

		protected bool initialized;

		protected List<float> distances;

		protected Transform rootTransform;

		protected List<Vector3> tailLookDirections;

		protected List<Vector3> lookBackDirections;

		protected List<Quaternion> lookBackOffsets;

		protected List<Quaternion> animatedCorrections;

		protected Vector3 firstBoneInitialRotation;

		protected Quaternion firstBoneInitialRotationQ;

		protected bool preAutoCorrect;

		protected List<Vector3> collisionOffsets;

		protected List<float> collisionFlags;

		protected List<Collision> collisionContacts;

		public bool CollisionLookBack;

		public bool IsInitialized
		{
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected virtual void Reset()
		{
		}

		protected virtual void Init()
		{
		}

		protected virtual void CoputeHelperVariables()
		{
		}

		protected virtual void ConfigureBonesTransforms()
		{
		}

		public void AutoGetTailTransforms(bool editor = false)
		{
		}

		protected virtual void PrepareTailPoints()
		{
		}

		protected void Start()
		{
		}

		[IteratorStateMachine(typeof(<InitInLate>d__60))]
		protected IEnumerator InitInLate()
		{
			return null;
		}

		public virtual void CalculateOffsets()
		{
		}

		protected virtual void MotionCalculations()
		{
		}

		protected virtual void SetTailTransformsFromPoints()
		{
		}

		protected virtual Quaternion CalculateTargetRotation(Vector3 startLookPos, Vector3 currentPos, [Optional] FTail_Point previousTailPoint, [Optional] FTail_Point currentTailPoint, int lookDirectionFixIndex = 0)
		{
			return default(Quaternion);
		}

		protected virtual void OnDestroy()
		{
		}

		protected void ApplyAutoCorrection()
		{
		}

		public void QueueComponentToLastUpdate()
		{
		}

		public virtual void OnValidate()
		{
		}

		private void AddColliders()
		{
		}

		internal void CollisionDetection(int index, Collision collision)
		{
		}

		internal void ExitCollision(int index)
		{
		}

		protected void UseCollisionContact(int index)
		{
		}

		protected Vector3 GetColliderBoxSizeFor(List<Transform> transforms, int i)
		{
			return default(Vector3);
		}

		protected float GetColliderSphereRadiusFor(List<Transform> transforms, int i)
		{
			return default(float);
		}
	}
}
