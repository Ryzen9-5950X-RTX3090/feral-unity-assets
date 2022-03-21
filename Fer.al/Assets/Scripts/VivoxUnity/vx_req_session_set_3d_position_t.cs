using System;
using System.Runtime.InteropServices;

public class vx_req_session_set_3d_position_t : IDisposable
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

	public SWIGTYPE_p_double speaker_velocity
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_double speaker_at_orientation
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_double speaker_up_orientation
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_double speaker_left_orientation
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_double listener_position
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_double listener_velocity
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_double listener_at_orientation
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_double listener_up_orientation
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public SWIGTYPE_p_double listener_left_orientation
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public orientation_type type
	{
		get
		{
			return default(orientation_type);
		}
		set
		{
		}
	}

	public req_disposition_type_t req_disposition_type
	{
		get
		{
			return default(req_disposition_type_t);
		}
		set
		{
		}
	}

	internal vx_req_session_set_3d_position_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_req_session_set_3d_position_t obj)
	{
		return default(HandleRef);
	}

	~vx_req_session_set_3d_position_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public static implicit operator vx_req_base_t(vx_req_session_set_3d_position_t t)
	{
		return null;
	}

	public vx_req_session_set_3d_position_t()
	{
	}

	public void Set3DPosition(float[] speakerPos, float[] listenerPos, float[] listenerAtOrient, float[] listenerUpOrient)
	{
	}
}
