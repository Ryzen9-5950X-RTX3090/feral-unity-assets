using System;
using System.Runtime.InteropServices;

public class vx_req_channel_set_lock_mode_t : IDisposable
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

	public string channel_uri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_channel_lock_mode lock_mode
	{
		get
		{
			return default(vx_channel_lock_mode);
		}
		set
		{
		}
	}

	internal vx_req_channel_set_lock_mode_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_channel_set_lock_mode_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_channel_set_lock_mode_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_req_base_t(vx_req_channel_set_lock_mode_t t)
	{
		return null;
	}

	public vx_req_channel_set_lock_mode_t()
	{
	}
}
