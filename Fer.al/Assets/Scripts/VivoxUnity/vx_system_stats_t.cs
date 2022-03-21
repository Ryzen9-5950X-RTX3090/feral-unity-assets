using System;
using System.Runtime.InteropServices;

public class vx_system_stats_t : IDisposable
{
	private HandleRef swigCPtr;

	protected bool swigCMemOwn;

	public int ss_size
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int ar_source_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int ar_source_queue_limit
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int ar_source_queue_overflows
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int ar_source_poll_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public uint msgovrld_count
	{
		get
		{
			return default(uint);
		}
		set
		{
		}
	}

	public vx_stat_sample_t ar_source_free_buffers
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_stat_sample_t ar_source_queue_depth
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_stat_thread_t vp_thread
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public vx_stat_thread_t ticker_thread
	{
		get
		{
			return null;
		}
		set
		{
		}
	}

	public int clnt_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int lc_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int mps_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int mpsg_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int strms_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int strr_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int strss_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	public int vp_count
	{
		get
		{
			return default(int);
		}
		set
		{
		}
	}

	internal vx_system_stats_t(IntPtr cPtr, bool cMemoryOwn)
	{
	}

	internal static HandleRef getCPtr(vx_system_stats_t obj)
	{
		return default(HandleRef);
	}

	~vx_system_stats_t()
	{
	}

	public virtual void Dispose()
	{
	}

	public vx_system_stats_t()
	{
	}
}
