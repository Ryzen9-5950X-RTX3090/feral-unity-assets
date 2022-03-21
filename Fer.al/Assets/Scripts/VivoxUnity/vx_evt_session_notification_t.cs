using System;
using System.Runtime.InteropServices;

public class vx_evt_session_notification_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public vx_evt_base_t base_
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_session_notification_state state
	{
		get
		{
			return default(vx_session_notification_state);
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

	public string participant_uri
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

	public string encoded_uri_with_tag
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int is_current_user
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_evt_session_notification_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_session_notification_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_session_notification_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_session_notification_t()
	{
	}
}
