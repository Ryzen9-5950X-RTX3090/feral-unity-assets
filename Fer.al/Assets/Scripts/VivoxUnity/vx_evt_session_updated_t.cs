using System;
using System.Runtime.InteropServices;

public class vx_evt_session_updated_t : IDisposable
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

	public int is_muted
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int volume
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int transmit_enabled
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_focused
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_double speaker_position
	{
		get
		{
			return null;
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

	public int is_text_muted
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_ad_playing
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_evt_session_updated_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_session_updated_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_session_updated_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_session_updated_t()
	{
	}
}
