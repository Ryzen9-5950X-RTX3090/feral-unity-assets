using System;
using System.Runtime.InteropServices;

public class vx_evt_sessiongroup_updated_t : IDisposable
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

	public long first_frame_timestamp_us
	{
		get
		{
			return default(long);
		}
		set
		{
		}
	}

	internal vx_evt_sessiongroup_updated_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_sessiongroup_updated_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_sessiongroup_updated_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_sessiongroup_updated_t()
	{
	}
}
