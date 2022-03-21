using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;
using UnityEngine.SceneManagement;

namespace Cinemachine.PostFX
{
	[ExecuteAlways]
	[DisallowMultipleComponent]
	[SaveDuringPlay]
	[AddComponentMenu("")]
	[HelpURL("https://docs.unity3d.com/Packages/com.unity.cinemachine@2.6/manual/CinemachinePostProcessing.html")]
	[DocumentationSorting(DocumentationSortingAttribute.Level.UserRef)]
	public class CinemachinePostProcessing : CinemachineExtension
	{
		public enum FocusTrackingMode
		{
			None,
			LookAtTarget,
			FollowTarget,
			CustomTarget,
			Camera
		}

		private class VcamExtraState
		{
			public PostProcessProfile mProfileCopy;

			public void CreateProfileCopy(PostProcessProfile source)
			{
			}

			public void DestroyProfileCopy()
			{
			}
		}

		[HideInInspector]
		public bool m_FocusTracksTarget;

		[Tooltip("If the profile has the appropriate overrides, will set the base focus distance to be the distance from the selected target to the camera.The Focus Offset field will then modify that distance.")]
		public FocusTrackingMode m_FocusTracking;

		[Tooltip("The target to use if Focus Tracks Target is set to Custom Target")]
		public Transform m_FocusTarget;

		[Tooltip("Offset from target distance, to be used with Focus Tracks Target.  Offsets the sharpest point away from the location of the focus target.")]
		public float m_FocusOffset;

		[Tooltip("This Post-Processing profile will be applied whenever this virtual camera is live")]
		public PostProcessProfile m_Profile;

		private static string sVolumeOwnerName;

		private static List<PostProcessVolume> sVolumes;

		private static Dictionary<CinemachineBrain, PostProcessLayer> mBrainToLayer;

		public bool IsValid
		{
			get
			{
				return default(bool);
			}
		}

		public void InvalidateCachedProfile()
		{
		}

		protected override void OnEnable()
		{
		}

		protected override void OnDestroy()
		{
		}

		protected override void PostPipelineStageCallback(CinemachineVirtualCameraBase vcam, CinemachineCore.Stage stage, ref CameraState state, float deltaTime)
		{
		}

		private static void OnCameraCut(CinemachineBrain brain)
		{
		}

		private static void ApplyPostFX(CinemachineBrain brain)
		{
		}

		private static List<PostProcessVolume> GetDynamicBrainVolumes(CinemachineBrain brain, PostProcessLayer ppLayer, int minVolumes)
		{
			return null;
		}

		private static PostProcessLayer GetPPLayer(CinemachineBrain brain)
		{
			return null;
		}

		private static void OnSceneUnloaded(Scene scene)
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule()
		{
		}
	}
}
