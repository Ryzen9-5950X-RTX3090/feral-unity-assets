using System;
using System.Runtime.InteropServices;

public class vx_before_recv_audio_mixed_participant_data_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public string participant_uri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_short pcm_frames
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int pcm_frame_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int audio_frame_rate
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int channels_per_frame
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_before_recv_audio_mixed_participant_data_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_before_recv_audio_mixed_participant_data_t obj)
	{
		return default(HandleRef);
	}

	~vx_before_recv_audio_mixed_participant_data_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_before_recv_audio_mixed_participant_data_t()
	{
	}
}
