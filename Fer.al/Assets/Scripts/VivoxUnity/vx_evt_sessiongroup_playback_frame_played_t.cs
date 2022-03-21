using System;
using System.Runtime.InteropServices;

public class vx_evt_sessiongroup_playback_frame_played_t : IDisposable
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

	public int first_frame
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int current_frame
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int total_frames
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_evt_sessiongroup_playback_frame_played_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_evt_sessiongroup_playback_frame_played_t obj)
	{
		return default(HandleRef);
	}

	~vx_evt_sessiongroup_playback_frame_played_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_evt_sessiongroup_playback_frame_played_t()
	{
	}
}
