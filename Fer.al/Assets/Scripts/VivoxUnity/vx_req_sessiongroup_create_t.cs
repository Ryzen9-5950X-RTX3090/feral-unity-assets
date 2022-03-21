using System;
using System.Runtime.InteropServices;

public class vx_req_sessiongroup_create_t : IDisposable
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

	public vx_sessiongroup_type type
	{
		get
		{
			return default(vx_sessiongroup_type);
		}
		set
		{
		}
	}

	public int loop_mode_duration_seconds
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string capture_device_id
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string render_device_id
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string alias_username
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string sessiongroup_handle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_req_sessiongroup_create_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_sessiongroup_create_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_sessiongroup_create_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_req_base_t(vx_req_sessiongroup_create_t t)
	{
		return null;
	}

	public vx_req_sessiongroup_create_t()
	{
	}
}
