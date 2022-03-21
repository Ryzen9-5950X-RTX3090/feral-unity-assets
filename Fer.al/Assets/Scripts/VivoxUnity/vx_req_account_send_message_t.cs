using System;
using System.Runtime.InteropServices;

public class vx_req_account_send_message_t : IDisposable
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

	public string user_uri
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

	internal vx_req_account_send_message_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_account_send_message_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_account_send_message_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_req_base_t(vx_req_account_send_message_t t)
	{
		return null;
	}

	public vx_req_account_send_message_t()
	{
	}
}
