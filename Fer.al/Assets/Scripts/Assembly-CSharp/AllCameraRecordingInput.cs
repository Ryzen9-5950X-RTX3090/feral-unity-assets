using System;
using System.Collections;
using System.Runtime.CompilerServices;
using NatSuite.Recorders;
using NatSuite.Recorders.Clocks;
using UnityEngine;

public class AllCameraRecordingInput : MonoBehaviour, IDisposable
{
	[SerializeField]
	private int _frameSkip;

	private IMediaRecorder _mediaRecorder;

	private IClock _clock;

	private RenderTextureDescriptor _frameDescriptor;

	private Texture2D _readbackBuffer;

	private Texture2D _mouseTexture;

	private byte[] _pixelBuffer;

	private int _frameCount;

	private bool _isRecording;

	public void StartRecording(IMediaRecorder mediaRecorder, IClock clock)
	{
	}

	public void SetCursorTexture(Texture2D texture2D)
	{
	}

	public void Dispose()
	{
	}

	[IteratorStateMachine(typeof(<OnFrame>d__12))]
	private IEnumerator OnFrame()
	{
		return null;
	}
}
