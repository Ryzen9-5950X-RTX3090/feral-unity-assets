using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using Rewired.Config;
using Rewired.Data;
using Rewired.Platforms;
using Rewired.Utils.Interfaces;
using UnityEngine;

namespace Rewired
{
	[ExecuteInEditMode]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[AddComponentMenu("")]
	[Browsable(false)]
	public abstract class InputManager_Base : MonoBehaviour
	{
		private enum ExceptionPoint
		{
			Initialization,
			Update,
			Destroy
		}

		[SerializeField]
		[CustomObfuscation]
		private bool _dontDestroyOnLoad;

		[CustomObfuscation]
		[SerializeField]
		private UserData _userData;

		[SerializeField]
		[CustomObfuscation]
		private ControllerDataFiles _controllerDataFiles;

		protected bool isCompiling;

		[NonSerialized]
		private bool initialized;

		[NonSerialized]
		private bool criticalError;

		[NonSerialized]
		protected EditorPlatform editorPlatform;

		[NonSerialized]
		protected Platform platform;

		[NonSerialized]
		protected WebplayerPlatform webplayerPlatform;

		[NonSerialized]
		protected bool isEditor;

		[NonSerialized]
		protected bool _detectedPlatformInEditor;

		[NonSerialized]
		[CustomObfuscation]
		protected ScriptingBackend scriptingBackend;

		[NonSerialized]
		[CustomObfuscation]
		protected ScriptingAPILevel scriptingAPILevel;

		[NonSerialized]
		private bool _duplicateRIMError;

		private bool _isAwake;

		public UserData userData
		{
			get
			{
				return null;
			}
			internal set
			{
			}
		}

		public ControllerDataFiles dataFiles
		{
			get
			{
				return null;
			}
		}

		public bool runInEditMode
		{
			get
			{
				return default(bool);
			}
			set
			{
			}
		}

		internal bool isRunningInEditMode
		{
			get
			{
				return default(bool);
			}
		}

		[CustomObfuscation]
		private void Awake()
		{
		}

		[CustomObfuscation]
		private void OnEnable()
		{
		}

		[CustomObfuscation]
		private void OnDisable()
		{
		}

		[CustomObfuscation]
		private void OnDestroy()
		{
		}

		[CustomObfuscation]
		private void OnApplicationFocus(bool isFocused)
		{
		}

		[CustomObfuscation]
		private void Start()
		{
		}

		[CustomObfuscation]
		private void Update()
		{
		}

		[CustomObfuscation]
		private void FixedUpdate()
		{
		}

		[CustomObfuscation]
		private void LateUpdate()
		{
		}

		internal void OnGUIUpdate()
		{
		}

		internal void DoUpdate(UpdateLoopType updateLoopType, UpdateLoopSetting updateLoopSettingBit)
		{
		}

		internal void TryStartRunInEditMode()
		{
		}

		internal void TryStopRunInEditMode()
		{
		}

		private bool ManualInitialize()
		{
			return default(bool);
		}

		private void Initialize()
		{
		}

		private object InitializePlatform(ConfigVars configVars)
		{
			return null;
		}

		private List<Assembly> GetNativeAssembliesFromResources()
		{
			return null;
		}

		private List<Assembly> GetNativeAssembliesByReflection()
		{
			return null;
		}

		private byte[] GetNativeDLLBytesByReflection()
		{
			return null;
		}

		private void AddTextAssetInResourcesToList(List<TextAsset> list, List<string> dllPaths)
		{
		}

		private string SetPlatformToEditorPlatform()
		{
			return null;
		}

		private bool CheckEditorPlatformMatches()
		{
			return default(bool);
		}

		private string GetPlatformSpecificAssemblyName()
		{
			return null;
		}

		private bool IsOnlyManagerInScene()
		{
			return default(bool);
		}

		protected void RecompileStart()
		{
		}

		protected void RecompileEnd()
		{
		}

		protected void OnSceneLoaded()
		{
		}

		private void HandleException(ExceptionPoint location, string message, Exception exception)
		{
		}

		[CustomObfuscation]
		internal void ResetAll()
		{
		}

		[CustomObfuscation]
		internal EditorPlatform GetEditorPlatform()
		{
			return default(EditorPlatform);
		}

		[CustomObfuscation]
		internal void GetSupportedEditModeControllerTypes(out bool keyboardSupported, out bool mouseSupported, out bool joystickSupported)
		{
		}

		[CustomObfuscation]
		internal bool IsEditModeSupported()
		{
			return default(bool);
		}

		protected abstract void OnInitialized();

		protected abstract void OnDeinitialized();

		protected abstract void DetectPlatform();

		protected abstract void CheckRecompile();

		protected abstract IExternalTools GetExternalTools();
	}
}
