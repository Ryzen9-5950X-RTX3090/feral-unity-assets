using System;
using System.Runtime.InteropServices;

public class vx_tts_utterance_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public SWIGTYPE_p_vx_tts_utterance_impl utterance_obj
	{
		get
		{
			return null;
		}
	}

	public SWIGTYPE_p_short speech_buffer
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int sample_rate
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int num_frames
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int num_channels
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_tts_utterance_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_tts_utterance_t obj)
	{
		return default(HandleRef);
	}

	~vx_tts_utterance_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_tts_utterance_t()
	{
	}
}
