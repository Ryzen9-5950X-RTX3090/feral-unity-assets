using System;
using System.Runtime.InteropServices;

public class vx_resp_aux_get_render_devices_t : IDisposable
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

	public int count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_p_vx_device render_devices
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_device_t current_render_device
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_device_t effective_render_device
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_device_t default_render_device
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_device_t default_communication_render_device
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_resp_aux_get_render_devices_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_resp_aux_get_render_devices_t obj)
	{
		return default(HandleRef);
	}

	~vx_resp_aux_get_render_devices_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_resp_aux_get_render_devices_t()
	{
	}
}
