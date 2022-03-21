using System.Collections;
using System.Runtime.CompilerServices;
using BestHTTP.Examples.Helpers;
using UnityEngine;
using UnityEngine.UI;

namespace BestHTTP.Examples.HTTP
{
	public sealed class AssetBundleSample : SampleBase
	{
		[SerializeField]
		[Tooltip("The url of the resource to download")]
		private string _path;

		[SerializeField]
		private string _assetnameInBundle;

		[SerializeField]
		private Text _statusText;

		[SerializeField]
		private RawImage _rawImage;

		[SerializeField]
		private Button _downloadButton;

		private HTTPRequest request;

		private AssetBundle cachedBundle;

		protected override void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnStartDownloadButton()
		{
		}

		[IteratorStateMachine(typeof(<DownloadAssetBundle>d__10))]
		private IEnumerator DownloadAssetBundle()
		{
			return null;
		}

		[IteratorStateMachine(typeof(<ProcessAssetBundle>d__11))]
		private IEnumerator ProcessAssetBundle(AssetBundle bundle)
		{
			return null;
		}

		private void UnloadBundle()
		{
		}
	}
}
