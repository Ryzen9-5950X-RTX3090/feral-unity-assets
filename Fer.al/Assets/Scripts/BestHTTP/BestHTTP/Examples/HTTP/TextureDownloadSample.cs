using System.Collections.Generic;
using BestHTTP.Examples.Helpers;
using UnityEngine;
using UnityEngine.UI;

namespace BestHTTP.Examples.HTTP
{
	public sealed class TextureDownloadSample : SampleBase
	{
		[SerializeField]
		[Header("Texture Download Example")]
		[Tooltip("The URL of the server that will serve the image resources")]
		private string _path;

		[SerializeField]
		[Tooltip("The downloadable images")]
		private string[] _imageNames;

		[SerializeField]
		private RawImage[] _images;

		[SerializeField]
		private Text _maxConnectionPerServerLabel;

		[SerializeField]
		private Text _cacheLabel;

		private byte savedMaxConnectionPerServer;

		private bool allDownloadedFromLocalCache;

		private List<HTTPRequest> activeRequests;

		protected override void Start()
		{
		}

		private void OnDestroy()
		{
		}

		public void OnMaxConnectionPerServerChanged(float value)
		{
		}

		public void DownloadImages()
		{
		}

		private void ImageDownloaded(HTTPRequest req, HTTPResponse resp)
		{
		}
	}
}
