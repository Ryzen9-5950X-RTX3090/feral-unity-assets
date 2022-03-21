namespace BestHTTP.Examples.HTTP
{
	public sealed class ResumableStreamingSample : StreamingSample
	{
		private const string ProcessedBytesKey = "ProcessedBytes";

		private const string DownloadLengthKey = "DownloadLength";

		private long downloadStartedAt;

		protected override long DownloadLength
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		protected override long ProcessedBytes
		{
			get
			{
				return default(long);
			}
			set
			{
			}
		}

		protected override void Start()
		{
		}

		protected override void SetupRequest()
		{
		}

		protected override void OnRequestFinished(HTTPRequest req, HTTPResponse resp)
		{
		}

		protected override void OnDownloadProgress(HTTPRequest originalRequest, long downloaded, long downloadLength)
		{
		}

		protected override void ResetProcessedValues()
		{
		}

		private float GetSavedProgress()
		{
			return default(float);
		}

		private void DeleteKeys()
		{
		}
	}
}
