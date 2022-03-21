using UnityEngine;

namespace CodeStage.AntiCheat.Detectors
{
	[DisallowMultipleComponent]
	[AddComponentMenu("Code Stage/Anti-Cheat Toolkit/Time Cheating Detector")]
	[HelpURL("http://codestage.net/uas_files/actk/api/class_code_stage_1_1_anti_cheat_1_1_detectors_1_1_time_cheating_detector.html")]
	public class TimeCheatingDetector : ACTkDetectorBase<TimeCheatingDetector>
	{
		public delegate void OnlineTimeCallback(OnlineTimeResult result);

		public delegate void TimeCheatingDetectorEventHandler(CheckResult result, ErrorKind error);

		public struct OnlineTimeResult
		{
			public bool success;

			public string error;

			public long errorResponseCode;

			public double onlineSecondsUtc;

			internal void SetTime(double secondsUtc)
			{
			}

			internal void SetError(string errorText, long responseCode = -1L)
			{
			}

			public override string ToString()
			{
				return null;
			}
		}

		public enum CheckResult
		{
			Unknown = 0,
			CheckPassed = 5,
			WrongTimeDetected = 10,
			CheatDetected = 15,
			Error = 100
		}

		public enum ErrorKind
		{
			NoError = 0,
			IncorrectUri = 3,
			OnlineTimeError = 5,
			NotStarted = 10,
			AlreadyCheckingForCheat = 15,
			Unknown = 100
		}

		public enum RequestMethod
		{
			Head,
			Get
		}

		public const string ComponentName = "Time Cheating Detector";

		private const string FinalLogPrefix = "[ACTk] Time Cheating Detector: ";

		private const int DefaultTimeoutSeconds = 10;

		private const string ErrorMessage = "[ACTk] Time Cheating Detector:  is disabled with ACTK_PREVENT_INTERNET_PERMISSION conditional or is not supported on current platform!";

		protected override string GetComponentName()
		{
			return null;
		}

		protected override void StartDetectionAutomatically()
		{
		}
	}
}
