using System;
using UnityEngine.Networking;

[Serializable]
public class DownloadingBundle
{
	public string path;

	public ManifestDef manifestDef;

	public DownloadState state;

	[NonSerialized]
	public ulong remoteFileSize;

	public float priorProgress;

	public int downloadAttemptCount;

	public float downloadTimer;

	public BundleQueue queue;

	[NonSerialized]
	public UnityWebRequest webRequest;

	[NonSerialized]
	public bool waitForResponseCodeFunctionPointerStandalone;

	public float Progress
	{
		get
		{
			return default(float);
		}
	}

	public void StartDownload()
	{
	}

	public void OnDownloadSuccess()
	{
	}

	public void OnDownloadError()
	{
	}
}
