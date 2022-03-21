using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace Cinemachine
{
	public sealed class CinemachineCore
	{
		public enum Stage
		{
			Body,
			Aim,
			Noise,
			Finalize
		}

		public delegate float AxisInputDelegate(string axisName);

		public delegate CinemachineBlendDefinition GetBlendOverrideDelegate(ICinemachineCamera fromVcam, ICinemachineCamera toVcam, CinemachineBlendDefinition defaultBlend, MonoBehaviour owner);

		private class UpdateStatus
		{
			public int lastUpdateFrame;

			public int lastUpdateFixedFrame;

			public UpdateTracker.UpdateClock lastUpdateMode;

			public float lastUpdateDeltaTime;
		}

		internal enum UpdateFilter
		{
			Fixed = 0,
			Late = 1,
			Smart = 8,
			SmartFixed = 8,
			SmartLate = 9
		}

		public static readonly int kStreamingVersion;

		public static readonly string kVersionString;

		private static CinemachineCore sInstance;

		public static bool sShowHiddenObjects;

		public static AxisInputDelegate GetInputAxis;

		public static float UniformDeltaTimeOverride;

		public static float CurrentTimeOverride;

		public static GetBlendOverrideDelegate GetBlendOverride;

		public static CinemachineBrain.BrainEvent CameraUpdatedEvent;

		public static CinemachineBrain.BrainEvent CameraCutEvent;

		private List<CinemachineBrain> mActiveBrains;

		private List<CinemachineVirtualCameraBase> mActiveCameras;

		private List<List<CinemachineVirtualCameraBase>> mAllCameras;

		private CinemachineVirtualCameraBase mRoundRobinVcamLastFrame;

		private static float mLastUpdateTime;

		private Dictionary<CinemachineVirtualCameraBase, UpdateStatus> mUpdateStatus;

		public static CinemachineCore Instance
		{
			get
			{
				return null;
			}
		}

		public static float DeltaTime
		{
			get
			{
				return default(float);
			}
		}

		public static float CurrentTime
		{
			get
			{
				return default(float);
			}
		}

		public int BrainCount
		{
			get
			{
				return default(int);
			}
		}

		public int VirtualCameraCount
		{
			get
			{
				return default(int);
			}
		}

		private static int FixedFrameCount
		{
			[CompilerGenerated]
			get
			{
				return default(int);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		internal UpdateFilter CurrentUpdateFilter
		{
			[CompilerGenerated]
			get
			{
				return default(UpdateFilter);
			}
			[CompilerGenerated]
			set
			{
			}
		}

		public CinemachineBrain GetActiveBrain(int index)
		{
			return null;
		}

		internal void AddActiveBrain(CinemachineBrain brain)
		{
		}

		internal void RemoveActiveBrain(CinemachineBrain brain)
		{
		}

		public CinemachineVirtualCameraBase GetVirtualCamera(int index)
		{
			return null;
		}

		internal void AddActiveCamera(CinemachineVirtualCameraBase vcam)
		{
		}

		internal void RemoveActiveCamera(CinemachineVirtualCameraBase vcam)
		{
		}

		internal void CameraDestroyed(CinemachineVirtualCameraBase vcam)
		{
		}

		internal void CameraEnabled(CinemachineVirtualCameraBase vcam)
		{
		}

		internal void CameraDisabled(CinemachineVirtualCameraBase vcam)
		{
		}

		internal void UpdateAllActiveVirtualCameras(int layerMask, Vector3 worldUp, float deltaTime)
		{
		}

		internal void UpdateVirtualCamera(CinemachineVirtualCameraBase vcam, Vector3 worldUp, float deltaTime)
		{
		}

		[RuntimeInitializeOnLoadMethod]
		private static void InitializeModule()
		{
		}

		private static Transform GetUpdateTarget(CinemachineVirtualCameraBase vcam)
		{
			return null;
		}

		internal UpdateTracker.UpdateClock GetVcamUpdateStatus(CinemachineVirtualCameraBase vcam)
		{
			return default(UpdateTracker.UpdateClock);
		}

		public bool IsLive(ICinemachineCamera vcam)
		{
			return default(bool);
		}

		public void GenerateCameraActivationEvent(ICinemachineCamera vcam, ICinemachineCamera vcamFrom)
		{
		}

		public void GenerateCameraCutEvent(ICinemachineCamera vcam)
		{
		}

		public CinemachineBrain FindPotentialTargetBrain(CinemachineVirtualCameraBase vcam)
		{
			return null;
		}
	}
}
