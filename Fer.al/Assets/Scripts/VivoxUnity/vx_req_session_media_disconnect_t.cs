using System;
using System.Runtime.InteropServices;

public class vx_req_session_media_disconnect_t : IDisposable
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

	public string session_handle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_media_type media
	{
		get
		{
			return default(vx_media_type);
		}
		set
		{
		}
	}

	public vx_termination_status termination_status
	{
		get
		{
			return default(vx_termination_status);
		}
		set
		{
		}
	}

	internal vx_req_session_media_disconnect_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_session_media_disconnect_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_session_media_disconnect_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_req_base_t(vx_req_session_media_disconnect_t t)
	{
		return null;
	}

	public vx_req_session_media_disconnect_t()
	{
	}
}
