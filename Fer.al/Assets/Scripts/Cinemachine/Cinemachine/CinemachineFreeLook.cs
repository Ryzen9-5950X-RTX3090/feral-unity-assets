using System;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Serialization;

namespace Cinemachine
{
	[ExcludeFromPreset]
	[DisallowMultipleComponent]
	[ExecuteAlways]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.6/manual/CinemachineFreeLook.html")]
	[AddComponentMenu("Cinemachine/CinemachineFreeLook")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public class CinemachineFreeLook : CinemachineVirtualCameraBase
	{
		[Serializable]
		public struct Orbit
		{
			public float m_Height;

			public float m_Radius;

			public Orbit(float h, float r)
			{
			}
		}

		public delegate CinemachineVirtualCamera CreateRigDelegate(CinemachineFreeLook vcam, string name, CinemachineVirtualCamera copyFrom);

		public delegate void DestroyRigDelegate(GameObject rig);

		[NoSaveDuringPlay]
		[VcamTargetProperty]
		[Tooltip("Object for the camera children to look at (the aim target).")]
		public Transform m_LookAt;

		[NoSaveDuringPlay]
		[VcamTargetProperty]
		[Tooltip("Object for the camera children wants to move with (the body target).")]
		public Transform m_Follow;

		[Tooltip("If enabled, this lens setting will apply to all three child rigs, otherwise the child rig lens settings will be used")]
		[FormerlySerializedAs("m_UseCommonLensSetting")]
		public bool m_CommonLens;

		[LensSettingsProperty]
		[Tooltip("Specifies the lens properties of this Virtual Camera.  This generally mirrors the Unity Camera's lens settings, and will be used to drive the Unity camera when the vcam is active")]
		[FormerlySerializedAs("m_LensAttributes")]
		public LensSettings m_Lens;

		public TransitionParams m_Transitions;

		[HideInInspector]
		[SerializeField]
		[FormerlySerializedAs("m_BlendHint")]
		[FormerlySerializedAs("m_PositionBlending")]
		private BlendHint m_LegacyBlendHint;

		[AxisStateProperty]
		[Tooltip("The Vertical axis.  Value is 0..1.  Chooses how to blend the child rigs")]
		[Header("Axis Control")]
		public AxisState m_YAxis;

		[Tooltip("Controls how automatic recentering of the Y axis is accomplished")]
		public AxisState.Recentering m_YAxisRecentering;

		[AxisStateProperty]
		[Tooltip("The Horizontal axis.  Value is -180...180.  This is passed on to the rigs' OrbitalTransposer component")]
		public AxisState m_XAxis;

		[OrbitalTransposerHeadingProperty]
		[Tooltip("The definition of Forward.  Camera will follow behind.")]
		public CinemachineOrbitalTransposer.Heading m_Heading;

		[Tooltip("Controls how automatic recentering of the X axis is accomplished")]
		public AxisState.Recentering m_RecenterToTargetHeading;

		[Tooltip("The coordinate space to use when interpreting the offset from the target.  This is also used to set the camera's Up vector, which will be maintained when aiming the camera.")]
		[Header("Orbits")]
		public CinemachineTransposer.BindingMode m_BindingMode;

		[Tooltip("Controls how taut is the line that connects the rigs' orbits, which determines final placement on the Y axis")]
		[FormerlySerializedAs("m_SplineTension")]
		[Range(0f, 1f)]
		public float m_SplineCurvature;

		[Tooltip("The radius and height of the three orbiting rigs.")]
		public Orbit[] m_Orbits;

		[SerializeField]
		[HideInInspector]
		[FormerlySerializedAs("m_HeadingBias")]
		private float m_LegacyHeadingBias;

		private bool mUseLegacyRigDefinitions;

		private bool mIsDestroyed;

		private CameraState m_State;

		[SerializeField]
		[HideInInspector]
		[NoSaveDuringPlay]
		private CinemachineVirtualCamera[] m_Rigs;

		private CinemachineOrbitalTransposer[] mOrbitals;

		private CinemachineBlend mBlendA;

		private CinemachineBlend mBlendB;

		public static CreateRigDelegate CreateRigOverride;

		public static DestroyRigDelegate DestroyRigOverride;

		private Orbit[] m_CachedOrbits;

		private float m_CachedTension;

		private Vector4[] m_CachedKnots;

		private Vector4[] m_CachedCtrl1;

		private Vector4[] m_CachedCtrl2;

		public static string[] RigNames
		{
			get
			{
				return null;
			}
		}

		public override bool PreviousStateIsValid
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public override CameraState State
		{
			get
			{
				return default(CameraState);
			}
		}

		public override Transform LookAt
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override Transform Follow
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		private float CachedXAxisHeading
		{
			[CompilerGenerated]
			get
			{
				return default(float);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		protected override void OnValidate()
		{
		}

		public CinemachineVirtualCamera GetRig(int i)
		{
			return null;
		}

		protected override void OnEnable()
		{
		}

		public void UpdateInputAxisProvider()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void OnTransformChildrenChanged()
		{
		}

		private void Reset()
		{
		}

		public override bool IsLiveChild(ICinemachineCamera vcam, bool dominantChildOnly = false)
		{
			return default(bool);
		}

		public override void OnTargetObjectWarped(Transform target, Vector3 positionDelta)
		{
		}

		public override void ForceCameraPosition(Vector3 pos, Quaternion rot)
		{
		}

		public override void InternalUpdateCameraState(Vector3 worldUp, float deltaTime)
		{
		}

		public override void OnTransitionFromCamera(ICinemachineCamera fromCam, Vector3 worldUp, float deltaTime)
		{
		}

		private float GetYAxisClosestValue(Vector3 cameraPos, Vector3 up)
		{
			return default(float);
		}

		private void InvalidateRigCache()
		{
		}

		private void DestroyRigs()
		{
		}

		private CinemachineVirtualCamera[] CreateRigs(CinemachineVirtualCamera[] copyFrom)
		{
			return null;
		}

		private void UpdateRigCache()
		{
		}

		private int LocateExistingRigs(string[] rigNames, bool forceOrbital)
		{
			return default(int);
		}

		private float UpdateXAxisHeading(CinemachineOrbitalTransposer orbital, float deltaTime, Vector3 up)
		{
			return default(float);
		}

		private void PushSettingsToRigs()
		{
		}

		private float GetYAxisValue()
		{
			return default(float);
		}

		private CameraState CalculateNewState(Vector3 worldUp, float deltaTime)
		{
			return default(CameraState);
		}

		public Vector3 GetLocalPositionForCameraFromInput(float t)
		{
			return default(Vector3);
		}

		private void UpdateCachedSpline()
		{
		}
	}
}
