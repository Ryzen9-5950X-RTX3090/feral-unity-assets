using System;
using System.Runtime.InteropServices;

public class vx_req_base_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public vx_message_base_t message
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_request_type type
	{
		get
		{
			return default(vx_request_type);
		}
		set
		{
		}
	}

	public string cookie
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_void vcookie
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_req_base_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_base_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_base_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_req_base_t()
	{
	}
}
