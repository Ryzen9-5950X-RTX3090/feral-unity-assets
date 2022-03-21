using System;
using System.Runtime.InteropServices;

public class vxa_capture_device_stats_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

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

	internal vxa_capture_device_stats_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vxa_capture_device_stats_t obj)
	{
		return default(HandleRef);
	}

	~vxa_capture_device_stats_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vxa_capture_device_stats_t()
	{
	}
}
