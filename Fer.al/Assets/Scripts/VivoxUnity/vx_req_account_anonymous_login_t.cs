using System;
using System.Runtime.InteropServices;

public class vx_req_account_anonymous_login_t : IDisposable
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

	public string connector_handle
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string displayname
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int participant_property_frequency
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int enable_buddies_and_presence
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public vx_buddy_management_mode buddy_management_mode
	{
		get
		{
			return default(vx_buddy_management_mode);
		}
		set
		{
		}
	}

	public int autopost_crash_dumps
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string acct_mgmt_server
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string application_token
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string application_override
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string client_ip_override
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int enable_presence_persistence
	{
		get
		{
			return default(int);
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

	public string acct_name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string access_token
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_p_char initial_buddy_uris
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_p_char initial_blocked_uris
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_p_char initial_blocked_uris_presence_only
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_p_char initial_allowed_uris
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string languages
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_req_account_anonymous_login_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_account_anonymous_login_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_account_anonymous_login_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_req_base_t(vx_req_account_anonymous_login_t t)
	{
		return null;
	}

	public vx_req_account_anonymous_login_t()
	{
	}
}
