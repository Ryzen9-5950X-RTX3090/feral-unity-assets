using System;
using System.Runtime.InteropServices;

public class vx_req_session_create_t : IDisposable
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

	public string name
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string uri
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string password
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int connect_audio
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int join_audio
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int join_text
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public vx_password_hash_algorithm_t password_hash_algorithm
	{
		get
		{
			return default(vx_password_hash_algorithm_t);
		}
		set
		{
		}
	}

	public int connect_text
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int session_font_id
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int jitter_compensation
	{
		get
		{
			return default(int);
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

	internal vx_req_session_create_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_session_create_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_session_create_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_req_base_t(vx_req_session_create_t t)
	{
		return null;
	}

	public vx_req_session_create_t()
	{
	}
}
