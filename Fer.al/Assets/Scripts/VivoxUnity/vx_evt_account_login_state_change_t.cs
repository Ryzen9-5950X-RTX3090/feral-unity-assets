using System;
using System.Runtime.InteropServices;

public class vx_evt_account_login_state_change_t : IDisposable
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

	public vx_login_state_change_state state
	{
		get
		{
			return default(vx_login_state_change_state);
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

	public int status_code
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string status_string
	{
		get
		{
			return null;
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

	internal vx_evt_account_login_state_change_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_account_login_state_change_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_account_login_state_change_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_account_login_state_change_t()
	{
	}
}
