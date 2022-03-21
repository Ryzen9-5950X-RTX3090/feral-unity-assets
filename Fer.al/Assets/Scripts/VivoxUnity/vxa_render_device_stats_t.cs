using System;
using System.Runtime.InteropServices;

public class vxa_render_device_stats_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public int current_output_queue_depth_milliseconds
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int buffer_underrun_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int buffer_overrun_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int other_error_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int audio_queue_read_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int audio_queue_write_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int hardware_output_channels
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int hardware_preferred_samplerate
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int hardware_preferred_buffer_duration
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vxa_render_device_stats_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vxa_render_device_stats_t obj)
	{
		return default(HandleRef);
	}

	~vxa_render_device_stats_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vxa_render_device_stats_t()
	{
	}
}
