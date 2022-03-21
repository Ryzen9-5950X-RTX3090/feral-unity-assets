using System;
using System.Runtime.InteropServices;

public class vx_req_connector_create_t : IDisposable
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

	public string client_name
	{
		get
		{
			return null;
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

	public int minimum_port
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int maximum_port
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public vx_attempt_stun attempt_stun
	{
		get
		{
			return default(vx_attempt_stun);
		}
		set
		{
		}
	}

	public vx_connector_mode mode
	{
		get
		{
			return default(vx_connector_mode);
		}
		set
		{
		}
	}

	public string log_folder
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string log_filename_prefix
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string log_filename_suffix
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int log_level
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public vx_session_handle_type session_handle_type
	{
		get
		{
			return default(vx_session_handle_type);
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

	public int max_calls
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int allow_cross_domain_logins
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int default_codec
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string user_agent_id
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string media_probe_server
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string http_proxy_server_name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int http_proxy_server_port
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int enable_duplicate_participant_uris
	{
		get
		{
			return default(int);
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

	public uint configured_codecs
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	internal vx_req_connector_create_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_connector_create_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_connector_create_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_req_base_t(vx_req_connector_create_t t)
	{
		return null;
	}

	public vx_req_connector_create_t()
	{
	}
}
