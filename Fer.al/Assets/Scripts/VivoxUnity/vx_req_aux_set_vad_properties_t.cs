using System;
using System.Runtime.InteropServices;

public class vx_req_aux_set_vad_properties_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public vx_req_base_t base_
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

	public string account_handle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_req_aux_set_vad_properties_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_aux_set_vad_properties_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_aux_set_vad_properties_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_req_base_t(vx_req_aux_set_vad_properties_t t)
	{
		return null;
	}

	public vx_req_aux_set_vad_properties_t()
	{
	}
}
