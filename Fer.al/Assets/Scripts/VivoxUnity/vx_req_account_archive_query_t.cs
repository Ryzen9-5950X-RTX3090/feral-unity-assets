using System;
using System.Runtime.InteropServices;

public class vx_req_account_archive_query_t : IDisposable
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

	public string time_start
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string time_end
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string search_text
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string channel_uri
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

	public uint max
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public string before_id
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string after_id
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int first_message_index
	{
		get
		{
			return default(int);
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

	internal vx_req_account_archive_query_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_account_archive_query_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_account_archive_query_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_req_base_t(vx_req_account_archive_query_t t)
	{
		return null;
	}

	public vx_req_account_archive_query_t()
	{
	}
}
