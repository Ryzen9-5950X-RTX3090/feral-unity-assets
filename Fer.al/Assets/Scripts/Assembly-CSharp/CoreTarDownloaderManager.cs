using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;
using UnityEngine;
using UnityEngine.Networking;

public class CoreTarDownloaderManager : CoreManagerBase<CoreTarDownloaderManager>
{
	public enum TarBundleDownloadState
	{
		Idle,
		Downloading,
		FinishedDownloading,
		FailedDownloading,
		Extracting,
		FinishedExtracting,
		FailedExtracting,
		AlreadyCached
	}

	private class TarBundle
	{
		public string bundlePath;

		public string bundleFileName;

		public ManifestDef manifestDef;

		public UnityWebRequest webRequest;

		public bool useTGZ;

		public float priorProgress;

		public float priorLoggedProgress;

		public int downloadAttemptCount;

		public int downloadFailures;

		public float downloadTimer;

		private static float? _downloadTimeout;

		private int _extractLog;

		private Thread _extractThread;

		private bool _threadIsExtracting;

		private bool _extractSucceeded;

		public Stopwatch downloadStopwatch;

		public Stopwatch extractStopwatch;

		public TarBundleDownloadState state;

		public void BeginDownload()
		{
		}

		public void Update()
		{
		}

		private void UpdateDownload()
		{
		}

		public void ClearWebRequest()
		{
		}

		public void BeginExtract()
		{
		}

		private void StartExtractThread()
		{
		}

		private static bool ExtractTarFile(string inPath, string inOutPath)
		{
			return default(bool);
		}

		private static bool ExtractTgzFile(string inPath, string inOutPath)
		{
			return default(bool);
		}

		public void UpdateExtract()
		{
		}
	}

	private int _debugMaxConcurrent;

	private bool _debugShowResults;

	private Vector2 _debugScrollPos;

	private Coroutine _downloadingRoutine;

	private List<TarBundle> _tarBundles;

	private TimeSpan? _lastEstimatedTime;

	private float DownloadAverage
	{
		get
		{
			return default(float);
		}
	}

	private float ExtractAverage
	{
		get
		{
			return default(float);
		}
	}

	public override bool HasInitCoroutine()
	{
		return default(bool);
	}

	public void OnGUI()
	{
	}

	private void OnWindow(int inID)
	{
	}

	private void OnGUIResults()
	{
	}

	private void OnGUIMenu()
	{
	}

	private void OnGUIDownloading()
	{
	}

	public TimeSpan GetEstimatedTime()
	{
		return default(TimeSpan);
	}

	public string GetTotalMBString()
	{
		return null;
	}

	public string GetCompletedMBString()
	{
		return null;
	}

	public float GetProgressPercentage()
	{
		return default(float);
	}

	[IteratorStateMachine(typeof(<DownloadTars>d__22))]
	private IEnumerator DownloadTars(bool inUseTGZ, int inMaxConcurrent, Action<bool> inResult)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<InitCoroutine>d__23))]
	public override IEnumerator InitCoroutine()
	{
		return null;
	}

	public override void Deinit()
	{
	}
}
