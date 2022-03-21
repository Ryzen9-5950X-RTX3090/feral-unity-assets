using System;
using System.Runtime.InteropServices;

public class vx_req_session_send_notification_t : IDisposable
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

	public vx_notification_type notification_type
	{
		get
		{
			return default(vx_notification_type);
		}
		set
		{
		}
	}

	internal vx_req_session_send_notification_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_session_send_notification_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_session_send_notification_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_req_base_t(vx_req_session_send_notification_t t)
	{
		return null;
	}

	public vx_req_session_send_notification_t()
	{
	}
}
