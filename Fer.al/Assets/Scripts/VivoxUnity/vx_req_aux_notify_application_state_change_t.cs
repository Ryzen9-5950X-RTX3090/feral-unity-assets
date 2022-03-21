using System;
using System.Runtime.InteropServices;

public class vx_req_aux_notify_application_state_change_t : IDisposable
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

	public vx_application_state_notification_type_t notification_type
	{
		get
		{
			return default(vx_application_state_notification_type_t);
		}
		set
		{
		}
	}

	internal vx_req_aux_notify_application_state_change_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_aux_notify_application_state_change_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_aux_notify_application_state_change_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_req_base_t(vx_req_aux_notify_application_state_change_t t)
	{
		return null;
	}

	public vx_req_aux_notify_application_state_change_t()
	{
	}
}
