using System;
using System.Runtime.InteropServices;

public class vx_resp_connector_get_local_audio_info_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public vx_resp_base_t base_
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int speaker_volume
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_speaker_muted
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int mic_volume
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_mic_muted
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_resp_connector_get_local_audio_info_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_resp_connector_get_local_audio_info_t obj)
	{
		return default(HandleRef);
	}

	~vx_resp_connector_get_local_audio_info_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_resp_connector_get_local_audio_info_t()
	{
	}
}
