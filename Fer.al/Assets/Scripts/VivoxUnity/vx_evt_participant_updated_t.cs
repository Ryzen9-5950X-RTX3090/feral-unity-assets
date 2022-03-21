using System;
using System.Runtime.InteropServices;

public class vx_evt_participant_updated_t : IDisposable
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

	public int is_moderator_muted
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_speaking
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

	public double energy
	{
		get
		{
			return default(double);
		}
		set
		{
		}
	}

	public int active_media
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int is_muted_for_me
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

	public int is_moderator_text_muted
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public vx_participant_type type
	{
		get
		{
			return default(vx_participant_type);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_vx_participant_diagnostic_state_t diagnostic_states
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int diagnostic_state_count
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

	public int is_current_user
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int has_unavailable_capture_device
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int has_unavailable_render_device
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_evt_participant_updated_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_participant_updated_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_participant_updated_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_participant_updated_t()
	{
	}
}
