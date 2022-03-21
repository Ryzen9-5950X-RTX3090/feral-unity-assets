using System;
using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;

namespace CodeStage.AntiCheat.Detectors
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/WallHack Detector")]
	[HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_wall_hack_detector.html")]
	public class WallHackDetector : ACTkDetectorBase<WallHackDetector>
	{
		public const string ComponentName = "WallHack Detector";

		internal const string FinalLogPrefix = "[ACTk] WallHack Detector: ";

		internal const string WireframeShaderName = "Hidden/ACTk/WallHackTexture";

		private const string ServiceContainerName = "[WH Detector Service]";

		private const int ShaderTextureSize = 4;

		private const int RenderTextureSize = 4;

		private const int ColorsDifferenceThreshold = 5;

		private readonly Vector3 rigidPlayerVelocity;

		private readonly WaitForEndOfFrame waitForEndOfFrame;

		[SerializeField]
		[Tooltip("Check for the \"walk through the walls\" kind of cheats made via Rigidbody hacks?")]
		private bool checkRigidbody;

		[SerializeField]
		[Tooltip("Check for the \"walk through the walls\" kind of cheats made via Character Controller hacks?")]
		private bool checkController;

		[SerializeField]
		[Tooltip("Check for the \"see through the walls\" kind of cheats made via shader or driver hacks (wireframe, color alpha, etc.)?")]
		private bool checkWireframe;

		[SerializeField]
		[Tooltip("Check for the \"shoot through the walls\" kind of cheats made via Raycast hacks?")]
		private bool checkRaycast;

		[Tooltip("Delay between Wireframe module checks, from 1 up to 60 secs.")]
		[Range(1f, 60f)]
		public int wireframeDelay;

		[Tooltip("Delay between Raycast module checks, from 1 up to 60 secs.")]
		[Range(1f, 60f)]
		public int raycastDelay;

		[Tooltip("World position of the container for service objects within 3x3x3 cube (drawn as red wire cube in scene).")]
		public Vector3 spawnPosition;

		[Tooltip("Maximum false positives in a row for each detection module before registering a wall hack.")]
		public byte maxFalsePositives;

		private GameObject serviceContainer;

		private GameObject solidWall;

		private GameObject thinWall;

		private Camera wfCamera;

		private MeshRenderer foregroundRenderer;

		private MeshRenderer backgroundRenderer;

		private Color wfColor1;

		private Color wfColor2;

		private Shader wfShader;

		private Material wfMaterial;

		private Texture2D shaderTexture;

		private Texture2D targetTexture;

		private RenderTexture renderTexture;

		private int whLayer;

		private int raycastMask;

		private Rigidbody rigidPlayer;

		private CharacterController charControllerPlayer;

		private float charControllerVelocity;

		private byte rigidbodyDetections;

		private byte controllerDetections;

		private byte wireframeDetections;

		private byte raycastDetections;

		private bool wireframeDetected;

		private readonly RaycastHit[] rayHits;

		public bool CheckRigidbody
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool CheckController
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool CheckWireframe
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public bool CheckRaycast
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		public static WallHackDetector AddToSceneOrGetExisting()
		{
			return null;
		}

		public static WallHackDetector StartDetection()
		{
			return null;
		}

		public static WallHackDetector StartDetection(Action callback)
		{
			return null;
		}

		public static WallHackDetector StartDetection(Action callback, Vector3 spawnPosition)
		{
			return null;
		}

		public static WallHackDetector StartDetection(Action callback, Vector3 spawnPosition, byte maxFalsePositives)
		{
			return null;
		}

		public static void StopDetection()
		{
		}

		public static void Dispose()
		{
		}

		private WallHackDetector()
		{
		}

		protected override void OnDestroy()
		{
		}

		private void FixedUpdate()
		{
		}

		private void Update()
		{
		}

		private WallHackDetector StartDetectionInternal(Action callback, Vector3 servicePosition, byte falsePositivesInRow)
		{
			return null;
		}

		protected override void StartDetectionAutomatically()
		{
		}

		protected override void PauseDetector()
		{
		}

		protected override bool ResumeDetector()
		{
			return default(bool);
		}

		protected override void StopDetectionInternal()
		{
		}

		protected override string GetComponentName()
		{
			return null;
		}

		private void UpdateServiceContainer()
		{
		}

		[IteratorStateMachine(typeof(<InitDetector>d__71))]
		private IEnumerator InitDetector()
		{
			return null;
		}

		private void StartRigidModule()
		{
		}

		private void StartControllerModule()
		{
		}

		private void StartWireframeModule()
		{
		}

		private void ShootWireframeModule()
		{
		}

		[IteratorStateMachine(typeof(<CaptureFrame>d__76))]
		private IEnumerator CaptureFrame()
		{
			return null;
		}

		private bool ColorsDiffer(Color a, Color b)
		{
			return default(bool);
		}

		private void StartRaycastModule()
		{
		}

		private void ShootRaycastModule()
		{
		}

		private void StopRigidModule()
		{
		}

		private void StopControllerModule()
		{
		}

		private void StopWireframeModule()
		{
		}

		private void StopRaycastModule()
		{
		}

		private void InitRigidModule()
		{
		}

		private void InitControllerModule()
		{
		}

		private void UninitRigidModule()
		{
		}

		private void UninitControllerModule()
		{
		}

		private bool Detect()
		{
			return default(bool);
		}

		private static Color32 GenerateColor()
		{
			return default(Color32);
		}

		private static bool ColorsSimilar(Color32 c1, Color32 c2, int tolerance)
		{
			return default(bool);
		}
	}
}
