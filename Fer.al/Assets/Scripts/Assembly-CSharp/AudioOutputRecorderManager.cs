using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using AOT;
using FMOD;

public class AudioOutputRecorderManager : SingletonManagerBase<AudioOutputRecorderManager>
{
	private delegate RESULT ReadCallbackDelegate(ref DSP_STATE dspState, IntPtr inBuffer, IntPtr outBuffer, uint length, int inChannels, ref int outChannels);

	private static readonly object _lockObject;

	private static int _readCallbackLogCount;

	private int _numberOfAudioChannels;

	private DSP_DESCRIPTION _dspDescription;

	private DSP _audioRecordingDSP;

	private ChannelGroup _masterChannelGroup;

	private List<float> _frontBuffer;

	private List<float> _backBuffer;

	public int NumberOfAudioChannels
	{
		get
		{
			return default(int);
		}
	}

	public bool IsInitialized
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public bool IsEnabled
	{
		[CompilerGenerated]
		get
		{
			return default(bool);
		}
		[CompilerGenerated]
		private set
		{
		}
	}

	public override void MStart()
	{
	}

	public override void MOnDestroy()
	{
	}

	[IteratorStateMachine(typeof(<WaitForFeralAudioManager>d__21))]
	private IEnumerator WaitForFeralAudioManager()
	{
		return null;
	}

	public void SetAudioFrameCapturingState(bool isEnabled)
	{
	}

	public float[] GetAudioFrameData()
	{
		return null;
	}

	public void ClearAudioFrameData()
	{
	}

	private void CheckInitialization()
	{
	}

	[MonoPInvokeCallback(typeof(ReadCallbackDelegate))]
	private static RESULT ReadCallbackStatic(ref DSP_STATE dspState, IntPtr inBuffer, IntPtr outBuffer, uint length, int channels, ref int outChannels)
	{
		return default(RESULT);
	}

	private RESULT ReadCallback(ref DSP_STATE dspState, IntPtr inBuffer, IntPtr outBuffer, uint length, int inChannels, ref int outChannels)
	{
		return default(RESULT);
	}

	private void ErrorOnFMODFailure(string functionName, RESULT result)
	{
	}

	private void ErrorOnFMODFailure(string functionName, RESULT result, RESULT[] nonFatalResults)
	{
	}

	private bool IsFatal(RESULT result, RESULT[] nonFatalResults)
	{
		return default(bool);
	}

	private void LimitedLog(string message)
	{
	}
}
