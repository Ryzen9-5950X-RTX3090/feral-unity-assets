using System.Collections;
using System.Runtime.CompilerServices;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

namespace Gaia
{
	[RequireComponent(typeof(Light))]
	public class GaiaUnderWaterEffects : MonoBehaviour
	{
		[Header("Global")]
		public GaiaConstants.EnvironmentRenderer m_currentRenderer;

		[Header("Caustic Settings")]
		[Tooltip("Sets if the light object follows the player")]
		public bool m_followPlayer;

		[Tooltip("Creates gameobject walls around the player to fix the horizon color issues with the fog rendering")]
		public bool m_useHorizonFix;

		[Tooltip("Creates simple underwater particles effect")]
		public bool m_useUnderwaterparticles;

		[Tooltip("Sets the caustics size, not this only works on directonial lights")]
		[Range(0f, 2000f)]
		public int m_causticsSize;

		[Tooltip("Caustic textures used to generate the effect")]
		public Texture[] m_cookies;

		[Tooltip("How many frame renders are made, higher the number the faster the animation. Recommend between 15-30 for optimial performance and visuals")]
		public float m_framesPerSecond;

		[Tooltip("What the current sea level is. Gaias default is 50")]
		public float m_sealevel;

		[Header("Underwater Settings")]
		[Range(0f, 1f)]
		[Tooltip("Sets the underwater ambiance audio volume")]
		public float m_underwaterSoundFXVolume;

		[Range(0f, 1f)]
		[Tooltip("Sets the water submerge audio volume")]
		public float m_waterSubmergeSounfFXVolume;

		[Tooltip("Sets the submerge down sound fx")]
		public AudioClip m_submergeSoundFXDown;

		[Tooltip("Sets the submerge up sound fx")]
		public AudioClip m_submergeSoundFXUp;

		[Tooltip("Sets the underwater fog color")]
		public Color32 m_underWaterFogColor;

		[Tooltip("Sets the underwater fog distance")]
		public float m_underWaterFogDistance;

		private Light mainlight;

		private Transform causticsObject;

		public Transform player;

		private int indexNumber;

		private bool coroutineStatus;

		[HideInInspector]
		public Color32 storedFogColor;

		[HideInInspector]
		public float storedFogDistance;

		private GameObject ambientAudio;

		private GameObject underwaterAudio;

		private GameObject horizonObject;

		[HideInInspector]
		public GameObject horizonObjectStored;

		private AudioSource objectAudioSource;

		private GameObject underwaterParticles;

		[HideInInspector]
		public GameObject underwaterParticlesStored;

		private Transform partentObject;

		private GaiaSettings m_gaiaSettings;

		private GaiaSceneInfo m_gaiaSceneInfo;

		public PostProcessVolume transitionPostFX;

		public PostProcessVolume underwaterPostFX;

		private void Start()
		{
		}

		private void OnEnable()
		{
		}

		public Transform GetThePlayer()
		{
			return null;
		}

		private static GameObject GetOrCreateEnvironmentParent()
		{
			return null;
		}

		private void OnDisable()
		{
		}

		private void Update()
		{
		}

		[IteratorStateMachine(typeof(<CausticsAnimation>d__39))]
		private IEnumerator CausticsAnimation(bool systemOn)
		{
			return null;
		}

		public void LoadCaustics()
		{
		}
	}
}
