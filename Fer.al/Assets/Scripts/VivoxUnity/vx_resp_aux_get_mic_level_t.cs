using System;
using System.Runtime.InteropServices;

public class vx_resp_aux_get_mic_level_t : IDisposable
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

	public int level
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_resp_aux_get_mic_level_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_resp_aux_get_mic_level_t obj)
	{
		return default(HandleRef);
	}

	~vx_resp_aux_get_mic_level_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_resp_aux_get_mic_level_t()
	{
	}
}
