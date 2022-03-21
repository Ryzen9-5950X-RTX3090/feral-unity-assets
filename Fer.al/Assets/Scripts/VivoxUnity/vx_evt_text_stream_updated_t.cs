using System;
using System.Runtime.InteropServices;

public class vx_evt_text_stream_updated_t : IDisposable
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

	public int enabled
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public vx_session_text_state state
	{
		get
		{
			return default(vx_session_text_state);
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

	internal vx_evt_text_stream_updated_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_text_stream_updated_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_text_stream_updated_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_text_stream_updated_t()
	{
	}
}
