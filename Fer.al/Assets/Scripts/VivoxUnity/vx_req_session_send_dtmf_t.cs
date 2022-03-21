using System;
using System.Runtime.InteropServices;

public class vx_req_session_send_dtmf_t : IDisposable
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

	public vx_dtmf_type dtmf_type
	{
		get
		{
			return default(vx_dtmf_type);
		}
		set
		{
		}
	}

	internal vx_req_session_send_dtmf_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_session_send_dtmf_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_session_send_dtmf_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_req_base_t(vx_req_session_send_dtmf_t t)
	{
		return null;
	}

	public vx_req_session_send_dtmf_t()
	{
	}
}
