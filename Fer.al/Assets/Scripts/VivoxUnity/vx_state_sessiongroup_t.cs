using System;
using System.Runtime.InteropServices;

public class vx_state_sessiongroup_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

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

	public int state_sessions_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public SWIGTYPE_p_p_vx_state_session state_sessions
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int in_delayed_playback
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public double current_playback_speed
	{
		get
		{
			return default(double);
		}
		set
		{
		}
	}

	public vx_sessiongroup_playback_mode current_playback_mode
	{
		get
		{
			return default(vx_sessiongroup_playback_mode);
		}
		set
		{
		}
	}

	public int playback_paused
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int loop_buffer_capacity
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int first_loop_frame
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int total_loop_frames_captured
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int last_loop_frame_played
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public string current_recording_filename
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int total_recorded_frames
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_state_sessiongroup_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_state_sessiongroup_t obj)
	{
		return default(HandleRef);
	}

	~vx_state_sessiongroup_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_state_sessiongroup_t()
	{
	}
}
