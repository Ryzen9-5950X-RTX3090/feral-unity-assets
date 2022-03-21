using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Common
{
	public abstract class KeepAliveBehaviour<T> : MonoBehaviour where T : KeepAliveBehaviour<T>
	{
		[Tooltip("Detector will survive new level (scene) load if checked.")]
		public bool keepAlive;

		protected int instancesInScene;

		public static T Instance
		{
			[CompilerGenerated]
			get
			{
				return null;
			}
			[CompilerGenerated]
			protected set
			{
			}
		}

		protected static T GetOrCreateInstance
		{
			get
			{
				return null;
			}
		}

		protected virtual void Awake()
		{
		}

		protected virtual void Start()
		{
		}

		protected virtual void OnDestroy()
		{
		}

		protected virtual void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}

		protected virtual bool Init(T instance, string detectorName)
		{
			return default(bool);
		}

		protected virtual void DisposeInternal()
		{
		}

		protected abstract string GetComponentName();
	}
}
