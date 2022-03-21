using System;
using System.Runtime.InteropServices;

public class vx_stat_thread_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public int interval
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int count_poll_lt_1ms
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int count_poll_lt_5ms
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int count_poll_lt_10ms
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int count_poll_lt_16ms
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int count_poll_lt_20ms
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int count_poll_lt_25ms
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int count_poll_gte_25ms
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_stat_thread_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_stat_thread_t obj)
	{
		return default(HandleRef);
	}

	~vx_stat_thread_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_stat_thread_t()
	{
	}
}
