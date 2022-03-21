using System;
using System.Runtime.InteropServices;

public class vx_req_aux_global_monitor_keyboard_mouse_t : IDisposable
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

	public string name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int code_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_int codes
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_req_aux_global_monitor_keyboard_mouse_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_aux_global_monitor_keyboard_mouse_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_aux_global_monitor_keyboard_mouse_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_req_base_t(vx_req_aux_global_monitor_keyboard_mouse_t t)
	{
		return null;
	}

	public vx_req_aux_global_monitor_keyboard_mouse_t()
	{
	}
}
