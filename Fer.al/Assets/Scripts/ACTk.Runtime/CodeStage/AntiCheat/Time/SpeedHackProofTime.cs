using CodeStage.AntiCheat.Common;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace CodeStage.AntiCheat.Time
{
	[DisallowMultipleComponent]
	[AddComponentMenu("")]
	public class SpeedHackProofTime : KeepAliveBehaviour<SpeedHackProofTime>
	{
		private static bool inited;

		private static bool speedHackDetected;

		private static float reliableTime;

		private static float reliableDeltaTime;

		private static float reliableUnscaledTime;

		private static float reliableUnscaledDeltaTime;

		private static float reliableRealtimeSinceStartup;

		private static float reliableTimeSinceLevelLoad;

		private static bool warningShot;

		private long currentReliableTicks;

		private long lastFrameReliableTicks;

		private long reliableTicksDelta;

		public static float time
		{
			get
			{
				return default(float);
			}
		}

		public static float unscaledTime
		{
			get
			{
				return default(float);
			}
		}

		public static float deltaTime
		{
			get
			{
				return default(float);
			}
		}

		public static float unscaledDeltaTime
		{
			get
			{
				return default(float);
			}
		}

		public static float realtimeSinceStartup
		{
			get
			{
				return default(float);
			}
		}

		public static float timeSinceLevelLoad
		{
			get
			{
				return default(float);
			}
		}

		protected override string GetComponentName()
		{
			return null;
		}

		private void Update()
		{
		}

		public static void Init()
		{
		}

		public static void Dispose()
		{
		}

		private bool InitInternal()
		{
			return default(bool);
		}

		private void UpdateTimeValuesFromUnityTime()
		{
		}

		private void UpdateReliableTimeValues()
		{
		}

		private void OnSpeedHackDetected()
		{
		}

		protected override void OnSceneLoaded(Scene scene, LoadSceneMode mode)
		{
		}
	}
}
