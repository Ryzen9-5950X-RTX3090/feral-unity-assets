using System;
using System.Runtime.InteropServices;

public class vx_evt_message_t : IDisposable
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

	public vx_message_state state
	{
		get
		{
			return default(vx_message_state);
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

	public string message_header
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string message_body
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string participant_displayname
	{
		get
		{
			return null;
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

	public string language
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string application_stanza_namespace
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string application_stanza_body
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_evt_message_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_message_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_message_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_message_t()
	{
	}
}
