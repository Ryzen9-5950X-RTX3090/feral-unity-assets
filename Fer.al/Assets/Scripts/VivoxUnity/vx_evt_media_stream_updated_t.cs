using System;
using System.Runtime.InteropServices;

public class vx_evt_media_stream_updated_t : IDisposable
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

	public string status_string
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_session_media_state state
	{
		get
		{
			return default(vx_session_media_state);
		}
		set
		{
		}
	}

	public int incoming
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string durable_media_id
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

	public vx_call_stats_t call_stats
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	internal vx_evt_media_stream_updated_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_media_stream_updated_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_media_stream_updated_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_media_stream_updated_t()
	{
	}
}
