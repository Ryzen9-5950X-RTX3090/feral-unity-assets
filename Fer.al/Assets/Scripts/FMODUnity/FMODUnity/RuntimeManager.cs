using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AOT;
using FMOD;
using FMOD.Studio;
using UnityEngine;

namespace FMODUnity
{
	[AddComponentMenu("")]
	public class RuntimeManager : MonoBehaviour
	{
		private struct LoadedBank
		{
			public Bank Bank;

			public int RefCount;
		}

		private class GuidComparer : IEqualityComparer<Guid>
		{
			bool IEqualityComparer<Guid>.Equals(Guid x, Guid y)
			{
				return default(bool);
			}

			int IEqualityComparer<Guid>.GetHashCode(Guid obj)
			{
				return default(int);
			}
		}

		private class AttachedInstance
		{
			public EventInstance instance;

			public Transform transform;

			public Rigidbody rigidBody;

			public Rigidbody2D rigidBody2D;
		}

		private static SystemNotInitializedException initException;

		private static RuntimeManager instance;

		private Platform currentPlatform;

		private FMOD.Studio.System studioSystem;

		private FMOD.System coreSystem;

		private DSP mixerHead;

		private long cachedStudioSystemHandle;

		private Dictionary<string, LoadedBank> loadedBanks;

		private Dictionary<Guid, EventDescription> cachedDescriptions;

		private List<StudioEventEmitter> activeEmitters;

		private List<AttachedInstance> attachedInstances;

		private bool listenerWarningIssued;

		protected bool isOverlayEnabled;

		private FMODRuntimeManagerOnGUIHelper overlayDrawer;

		private Rect windowRect;

		private string lastDebugText;

		private float lastDebugUpdate;

		public static List<StudioListener> Listeners;

		private static int numListeners;

		private static RuntimeManager Instance
		{
			get
			{
				return null;
			}
		}

		public static FMOD.Studio.System StudioSystem
		{
			get
			{
				return default(FMOD.Studio.System);
			}
		}

		public static FMOD.System CoreSystem
		{
			get
			{
				return default(FMOD.System);
			}
		}

		public static bool IsInitialized
		{
			get
			{
				return default(bool);
			}
		}

		public static bool HasBanksLoaded
		{
			get
			{
				return default(bool);
			}
		}

		[MonoPInvokeCallback(typeof(DEBUG_CALLBACK))]
		private static RESULT DEBUG_CALLBACK(DEBUG_FLAGS flags, IntPtr filePtr, int line, IntPtr funcPtr, IntPtr messagePtr)
		{
			return default(RESULT);
		}

		private void CheckInitResult(RESULT result, string cause)
		{
		}

		private RESULT Initialize()
		{
			return default(RESULT);
		}

		private static void SetThreadAffinities(Platform platform)
		{
		}

		public static int AddListener(StudioListener listener)
		{
			return default(int);
		}

		public static bool RemoveListener(StudioListener listener)
		{
			return default(bool);
		}

		private void Update()
		{
		}

		public static void RegisterActiveEmitter(StudioEventEmitter emitter)
		{
		}

		public static void DeregisterActiveEmitter(StudioEventEmitter emitter)
		{
		}

		public static void UpdateActiveEmitter(StudioEventEmitter emitter, bool force = false)
		{
		}

		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody rigidBody)
		{
		}

		public static void AttachInstanceToGameObject(EventInstance instance, Transform transform, Rigidbody2D rigidBody2D)
		{
		}

		public static void DetachInstanceFromGameObject(EventInstance instance)
		{
		}

		public void ExecuteOnGUI()
		{
		}

		private void Start()
		{
		}

		private void DrawDebugOverlay(int windowID)
		{
		}

		private void OnDestroy()
		{
		}

		private void OnApplicationPause(bool pauseStatus)
		{
		}

		private void loadedBankRegister(LoadedBank loadedBank, string bankPath, string bankName, bool loadSamples, RESULT loadResult)
		{
		}

		public static void LoadBank(string bankName, bool loadSamples = false)
		{
		}

		public static void LoadBank(TextAsset asset, bool loadSamples = false)
		{
		}

		private void LoadBanks(Settings fmodSettings)
		{
		}

		public static void UnloadBank(string bankName)
		{
		}

		public static bool AnyBankLoading()
		{
			return default(bool);
		}

		public static void WaitForAllLoads()
		{
		}

		public static Guid PathToGUID(string path)
		{
			return default(Guid);
		}

		public static EventInstance CreateInstance(string path)
		{
			return default(EventInstance);
		}

		public static EventInstance CreateInstance(Guid guid)
		{
			return default(EventInstance);
		}

		public static void PlayOneShot(string path, [Optional] Vector3 position)
		{
		}

		public static void PlayOneShot(Guid guid, [Optional] Vector3 position)
		{
		}

		public static void PlayOneShotAttached(string path, GameObject gameObject)
		{
		}

		public static void PlayOneShotAttached(Guid guid, GameObject gameObject)
		{
		}

		public static EventDescription GetEventDescription(string path)
		{
			return default(EventDescription);
		}

		public static EventDescription GetEventDescription(Guid guid)
		{
			return default(EventDescription);
		}

		public static void SetListenerLocation(GameObject gameObject, [Optional] Rigidbody rigidBody, [Optional] GameObject attenuationObject)
		{
		}

		public static void SetListenerLocation(GameObject gameObject, Rigidbody2D rigidBody2D, [Optional] GameObject attenuationObject)
		{
		}

		public static void SetListenerLocation(Transform transform, [Optional] GameObject attenuationObject)
		{
		}

		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, [Optional] Rigidbody rigidBody, [Optional] GameObject attenuationObject)
		{
		}

		public static void SetListenerLocation(int listenerIndex, GameObject gameObject, Rigidbody2D rigidBody2D, [Optional] GameObject attenuationObject)
		{
		}

		public static void SetListenerLocation(int listenerIndex, Transform transform, [Optional] GameObject attenuationObject)
		{
		}

		private static void SetListenerLocation3D(int listenerIndex, Transform transform, [Optional] Rigidbody rigidBody, [Optional] GameObject attenuationObject)
		{
		}

		private static void SetListenerLocation2D(int listenerIndex, Transform transform, [Optional] Rigidbody2D rigidBody, [Optional] GameObject attenuationObject)
		{
		}

		public static Bus GetBus(string path)
		{
			return default(Bus);
		}

		public static VCA GetVCA(string path)
		{
			return default(VCA);
		}

		public static void PauseAllEvents(bool paused)
		{
		}

		public static void MuteAllEvents(bool muted)
		{
		}

		public static bool HasBankLoaded(string loadedBank)
		{
			return default(bool);
		}
	}
}
