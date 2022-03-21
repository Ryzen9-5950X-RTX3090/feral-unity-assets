using System;
using System.Runtime.InteropServices;

public class vx_evt_participant_added_t : IDisposable
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

	public string account_name
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

	public int participant_type
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string application
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

	public string alias_username
	{
		get
		{
			return null;
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

	internal vx_evt_participant_added_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_participant_added_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_participant_added_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_participant_added_t()
	{
	}
}
