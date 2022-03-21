using System;
using System.Runtime.InteropServices;

public class vx_resp_connector_set_local_speaker_volume_t : IDisposable
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

	internal vx_resp_connector_set_local_speaker_volume_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_resp_connector_set_local_speaker_volume_t obj)
	{
		return default(HandleRef);
	}

	~vx_resp_connector_set_local_speaker_volume_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_resp_connector_set_local_speaker_volume_t()
	{
	}
}
