using System;
using System.Runtime.InteropServices;

public class vx_evt_session_archive_query_end_t : IDisposable
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

	public int return_code
	{
		get
		{
			return default(int);
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

	public string first_id
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public string last_id
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public uint first_index
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public uint count
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	internal vx_evt_session_archive_query_end_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_session_archive_query_end_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_session_archive_query_end_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_session_archive_query_end_t()
	{
	}
}
