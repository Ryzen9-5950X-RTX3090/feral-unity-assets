using System;
using System.Runtime.InteropServices;

public class vx_state_session_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

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

	public int is_audio_muted_for_me
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_text_muted_for_me
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_transmitting
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

	public int has_audio
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int has_text
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_incoming
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_positional
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_connected
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int state_participant_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_p_vx_state_participant state_participants
	{
		get
		{
			return null;
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

	internal vx_state_session_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_state_session_t obj)
	{
		return default(HandleRef);
	}

	~vx_state_session_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_state_session_t()
	{
	}
}
