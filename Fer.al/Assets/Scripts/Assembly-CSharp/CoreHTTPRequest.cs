using System;
using System.Collections;
using System.Runtime.CompilerServices;
using BestHTTP;

public class CoreHTTPRequest
{
	public enum ErrorMessageLogType
	{
		None,
		Report,
		Error
	}

	private string _url;

	private string _tempDestinationPath;

	private string _destinationPath;

	private int _forcedFinalSize;

	private bool _allowErrorLogs;

	private HTTPRequest _webRequest;

	private HTTPResponse _webRequestResponse;

	private string _webRequestError;

	private string _webRequestTiming;

	private bool _webRequestTimedOut;

	private float _webRequestProgress;

	private bool _webRequestFinished;

	private bool _webRequestSucceeded;

	private int _webRequestRetries;

	public float Progress
	{
		get
		{
			return default(float);
		}
	}

	public string DataAsText
	{
		get
		{
			return null;
		}
	}

	public byte[] DataAsBytes
	{
		get
		{
			return null;
		}
	}

	public bool Finished
	{
		get
		{
			return default(bool);
		}
	}

	public bool Succeeded
	{
		get
		{
			return default(bool);
		}
	}

	public int StatusCode
	{
		get
		{
			return default(int);
		}
	}

	[IteratorStateMachine(typeof(<DownloadText>d__14))]
	public IEnumerator DownloadText(string inURL)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<DownloadBinary>d__15))]
	public IEnumerator DownloadBinary(string inURL, string inTempDestinationPath, string inDestinationPath, Action<float> inProgressResult, bool inAllowGZIP = false, int inForcedFinalSize = -1, bool inAllowErrorLogs = true)
	{
		return null;
	}

	~CoreHTTPRequest()
	{
	}

	public void Dispose()
	{
	}

	[IteratorStateMachine(typeof(<WaitUntilFinished>d__26))]
	public IEnumerator WaitUntilFinished()
	{
		return null;
	}

	public string ErrorMessage(ErrorMessageLogType inLogType = ErrorMessageLogType.None)
	{
		return null;
	}

	[IteratorStateMachine(typeof(<MoveTempFileToFinalDestination>d__33))]
	public IEnumerator MoveTempFileToFinalDestination()
	{
		return null;
	}

	private void OnDownloadProgress(HTTPRequest inRequest, long downloaded, long inLength)
	{
	}

	private bool OnStreamingData(HTTPRequest inRequest, HTTPResponse inResponse, byte[] inDataFragment, int inDataFragmentLength)
	{
		return default(bool);
	}

	private void OnWebRequestFinished(HTTPRequest inRequest, HTTPResponse inResponse)
	{
	}
}
