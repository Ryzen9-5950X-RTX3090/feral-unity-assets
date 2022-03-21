using System;
using System.Runtime.InteropServices;

public class vx_state_account_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

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

	public string account_uri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string display_name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int is_anonymous_login
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int state_sessiongroups_count
	{
		get
		{
			return default(int);
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

	public SWIGTYPE_p_p_vx_state_sessiongroup state_sessiongroups
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int state_buddy_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int state_buddy_group_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_p_vx_state_buddy state_buddies
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_p_vx_state_buddy_group state_buddy_groups
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_state_account_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_state_account_t obj)
	{
		return default(HandleRef);
	}

	~vx_state_account_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_state_account_t()
	{
	}
}
