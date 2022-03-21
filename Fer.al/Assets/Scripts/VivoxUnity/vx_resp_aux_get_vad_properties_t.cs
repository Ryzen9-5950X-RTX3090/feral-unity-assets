using System;
using System.Runtime.InteropServices;

public class vx_resp_aux_get_vad_properties_t : IDisposable
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

	public int vad_hangover
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int vad_sensitivity
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int vad_noise_floor
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int vad_auto
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_resp_aux_get_vad_properties_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_resp_aux_get_vad_properties_t obj)
	{
		return default(HandleRef);
	}

	~vx_resp_aux_get_vad_properties_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_resp_aux_get_vad_properties_t()
	{
	}
}
