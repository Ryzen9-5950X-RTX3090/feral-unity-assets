using System;
using UnityEngine;

[ManagedBehaviourManager("CinematicManager")]
public class TimelineDownload : ManagedBehaviour
{
	[Serializable]
	public class DownloadInfo
	{
		[RootSelector("BundleID", "BundleIDChartData", false, false)]
		public string bundleId;

		public Transform parent;

		public Vector3 position;

		public Vector3 rotation;
	}

	[SerializeField]
	private bool _downloadOnStart;

	private bool _downloaded;

	public DownloadInfo[] downloadInfos;

	public override void MStart()
	{
	}

	public void Download()
	{
	}
}
