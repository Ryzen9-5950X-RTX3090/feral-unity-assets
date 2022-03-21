using System;
using System.Runtime.InteropServices;

public class vx_evt_account_archive_message_t : IDisposable
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

	public string query_id
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string time_stamp
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

	public int is_inbound
	{
		get
		{
			return default(int);
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

	public string message_id
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

	internal vx_evt_account_archive_message_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_account_archive_message_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_account_archive_message_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_account_archive_message_t()
	{
	}
}
